$branches = @('3x', '3x-dev', 'main', '2x-dev')

foreach($branch in $branches)
{
    git checkout $branch
    git pull
}


