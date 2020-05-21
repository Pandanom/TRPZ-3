using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using TimeSheetManager.Model;

namespace TimeSheetManager.ViewModel
{
//      date = 1,
//        project = 2,
//        mbtReq = 3,
//        tfsReq = 4,
//        taskName = 5,
//        taskDesc = 6,
//        plan = 7,
//        startTime = 8,
//        endTime = 9,
//        time = 10,
//        other = 0
    class DataGridBuilder
    {
        Table table;

        public DataGridBuilder(Table table)
        {
            this.table = table;
        }

        public void CreateColumns(ref DataGrid dataGrid)
        {
            
            var columns = table.header.columns;
            foreach (var c in columns)
            {
                dataGrid.Columns.Add(GetColumn(c));
            }
        }

        DataGridColumn GetColumn(Column c)
        {
            DataGridColumn col = null;
            switch (c.type)
            {
                case FieldType.date:
                    col = CreateDatePickerColumn(c.title);
                    col.Header = c.title;
                    break;
                case FieldType.mbtReq:
                case FieldType.tfsReq:
                case FieldType.project:
                    col = new DataGridComboBoxColumn();
                    break;
                default:
                    col = new DataGridTextColumn();
                    break;
            }
            col.Header = c.title;
            col.ClipboardContentBinding = new Binding(c.title);
            return col;

        }

        DataGridTemplateColumn CreateDatePickerColumn(string PropertyName)
        {
            DataGridTemplateColumn col = new DataGridTemplateColumn();
            FrameworkElementFactory datePickerFactoryElem = new FrameworkElementFactory(typeof(DatePicker));
            Binding dateBind = new Binding(PropertyName);
            dateBind.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            dateBind.Mode = BindingMode.TwoWay;
            datePickerFactoryElem.SetValue(DatePicker.SelectedDateProperty, dateBind);
            datePickerFactoryElem.SetValue(DatePicker.DisplayDateProperty, dateBind);
            DataTemplate cellTemplate = new DataTemplate();
            cellTemplate.VisualTree = datePickerFactoryElem;
            col.CellTemplate = cellTemplate;

            return col;

        }

    }
}
