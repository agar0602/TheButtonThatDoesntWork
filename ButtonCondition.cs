  ///The condition goes in the DAML file. I added mine directly under the </AddInInfo> section (hence the indentation).
  <conditions>
    <insertCondition id="button_on_selection" caption="button_on_selection">
      <state id="button_on" />
    </insertCondition>
  </conditions>
  
  
  ///Add condition to button after largeImage in DAML.
        <button id="WLM_Tab_Button1" caption="Calculate Survey Lines" className="Button1" loadOnClick="true" smallImage="pack://application:,,,/ArcGIS.Desktop.Resources;component/Images/TableCalculateField16.png" largeImage="pack://application:,,,/ArcGIS.Desktop.Resources;component/Images/TableCalculateField32.png" condition="button_on_selection">
          <tooltip heading="Calculate Survey Lines Table">Calculate values to populate layout table for survey lines
		  <disabledText /></tooltip>
        </button>