Import-Module SQLPS
$tables = ls SQLSERVER:\sql\desktop-a13901g\default\databases\tasks\tables
$tables | % {
    $table = $_
    $name = "$($table.Schema)$($table.Name)"

    if ($table.ForeignKeys.Count -eq 0) {
        return
    }

    Write-Output "$name [label=""$($table.Schema).$($table.Name)""]"
    $table.ForeignKeys | % {
        $fk = $_
        Write-Output "$name -> $($fk.ReferencedTableSchema)$($fk.ReferencedTable)"
    }
}