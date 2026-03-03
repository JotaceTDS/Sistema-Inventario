param(
    [string]$Servidor = "\\SERVIDOR-BD\sistema\Atualizacoes",
    [string]$ExeLocal = "C:\sistema\C#\Inventario\bin\Release\ControleInventario.exe"
)

Write-Host "=== PUBLICADOR DE ATUALIZAÇÃO ===" -ForegroundColor Cyan

if (-not (Test-Path $ExeLocal)) {
    Write-Host "❌ Executável não encontrado em: $ExeLocal" -ForegroundColor Red
    exit
}

$versionInfo = (Get-Item $ExeLocal).VersionInfo
$versao = $versionInfo.ProductVersion
$versaoLimpa = $versao.Replace(".", "_")

Write-Host "Versão detectada: $versao"
$confirm = Read-Host "Deseja realmente publicar essa versão para todos os usuários? (S/N)"
if ($confirm -ne "S" -and $confirm -ne "s") {
    Write-Host "🟡 Publicação cancelada."
    exit
}

$nomeExe = "ControleInventario_$versao.exe"
$xmlPath = Join-Path $Servidor "controleinventario.xml"
$changelog = "changelog_$versaoLimpa.html"
$changelogPath = Join-Path $Servidor $changelog

Copy-Item $ExeLocal "$Servidor\$nomeExe" -Force
Write-Host "✅ Novo executável publicado: $nomeExe" -ForegroundColor Green

"Versão publicada em $(Get-Date -Format 'dd/MM/yyyy HH:mm')" | Out-File $changelogPath -Encoding UTF8
"Versão: $versao" | Out-File $changelogPath -Append
Write-Host "📝 Changelog criado: $changelog"

$xmlContent = @"
<item>
  <version>$versao</version>
  <url>file://///SERVIDOR-BD/sistema/Atualizacoes/$nomeExe</url>
  <changelog>file://///SERVIDOR-BD/sistema/Atualizacoes/$changelog</changelog>
  <args>/VERYSILENT /SUPPRESSMSGBOXES /NORESTART /CLOSEAPPLICATIONS /RESTARTAPPLICATIONS</args>
  <mandatory>false</mandatory>
</item>
"@

Set-Content -Path $xmlPath -Value $xmlContent -Encoding UTF8
Write-Host "📦 XML atualizado com sucesso!" -ForegroundColor Green

Write-Host "`n🚀 Publicação concluída com sucesso para a versão $versao" -ForegroundColor Cyan
