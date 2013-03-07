param($installPath, $toolsPath, $package, $project)

foreach($topProjectItem in $project.ProjectItems)
{
    if($topProjectItem.Name.Equals("UiPath"))
    {
        foreach($uiProjectItem in $topProjectItem.ProjectItems)
        {
			if($uiProjectItem.Properties.Item("CopyToOutputDirectory"))
			{
				$uiProjectItem.Properties.Item("CopyToOutputDirectory").Value = 2 #Copy to output if newer
			}
            foreach($projItem in $uiProjectItem.ProjectItems)
            {
				if($projItem.Properties.Item("CopyToOutputDirectory"))
				{
					$projItem.Properties.Item("CopyToOutputDirectory").Value = 2 #Copy to output if newer
				}
            }
        }
    }
}