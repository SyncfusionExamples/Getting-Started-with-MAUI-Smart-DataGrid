# Getting Started with MAUI Smart DataGrid

This sample demonstrates how to get started with the .NET MAUI Smart DataGrid in a .NET MAUI application.

## Sample

```xaml
    <smartdatagrid:SfSmartDataGrid x:Name="dataGrid" ItemsSource="{Binding OrderInfoCollection}"
                                   ColumnWidthMode="Fill">

        <smartdatagrid:SfSmartDataGrid.AssistViewSettings>
            <smartdatagrid:DataGridAssistViewSettings SuggestedPrompts="{Binding Suggestions}"/>
        </smartdatagrid:SfSmartDataGrid.AssistViewSettings>

        <smartdatagrid:SfSmartDataGrid.Columns>
            <datagrid:DataGridNumericColumn HeaderText="Order ID" MappingName="OrderID" Format="0"
                                            HeaderTextAlignment="Center" CellTextAlignment="Center"/>
            <datagrid:DataGridTextColumn HeaderText="Customer ID" MappingName="CustomerID"
                                        HeaderTextAlignment="Center" CellTextAlignment="Center"/>
            <datagrid:DataGridTextColumn HeaderText="Name" MappingName="Customer"
                                        HeaderTextAlignment="Center" CellTextAlignment="Center"/>
            <datagrid:DataGridTextColumn HeaderText="Ship Country" MappingName="ShipCountry"
                                        HeaderTextAlignment="Center" CellTextAlignment="Center"/>
            <datagrid:DataGridTextColumn HeaderText="Ship City" MappingName="ShipCity"
                                        HeaderTextAlignment="Center" CellTextAlignment="Center"/>
        </smartdatagrid:SfSmartDataGrid.Columns>
    </smartdatagrid:SfSmartDataGrid>
```

## Requirements to run the demo

To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements)

## Troubleshooting:

### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion's samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion's samples.
