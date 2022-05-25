param (
    [string]$branch = ""
)

if($branch -eq "")
{
    Write-Host "A branch name is required (Usage: git-checkout branchName)" -ForegroundColor Red
    exit 0
}

git checkout $branch

Set-Location "../fake-xrm-easy-abstractions"
git checkout $branch

Set-Location "../fake-xrm-easy-core"
git checkout $branch

Set-Location "../fake-xrm-easy-plugins"
git checkout $branch

Set-Location "../fake-xrm-easy-messages"
git checkout $branch

if(!$branch.StartsWith("3x"))
{
    Set-Location "../fake-xrm-easy-code-activities"
    git checkout $branch
}

Set-Location "../fake-xrm-easy"


