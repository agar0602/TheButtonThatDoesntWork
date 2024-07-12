# TheButtonThatDoesntWork
Helpful links for ArcGIS Pro custom add-in button.

Use HelpfulLinks.txt to install and setup Visual Studio 2022 for use with ArcGIS Pro SDK for .NET. Current C# scripts work in ArcGIS Pro version 3.2.0.

Module1.cs script is where the map change event is subscribed to. Note the addition of the ArcGIS.Desktop.Mapping.Events trigger. This must be done in the module1.cs and not in the DAML because it needs to fire BEFORE the button is clicked. This event will be called in the condition that is applied inside the DAML.

ButtonCondition.cs is for the DAML and it is where you define the condition for the button.

ButtonPath.cs is for the button itself and most of this code will be generated when you create the button. This is where you'll drop the python script governing the geoprocessing of the button.

If you have any questions, feel free to email me at Andrew.Garcia@dep.nj.gov.
