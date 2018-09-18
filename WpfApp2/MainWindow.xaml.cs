using System.Windows;
using System.Windows.Controls;
using System.Windows.Ink;
using System.Windows.Media;

namespace WpfApp2
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        //声明一个DrawingAttributes对象(不进行初始化,带以后需要的时候在初始化对象)
        private DrawingAttributes drawingAttributes;

        public MainWindow()
        {
            InitializeComponent();

            //初始化DrawingAttributes对象
            drawingAttributes = new DrawingAttributes();
            //将前台的InkCanvas的默认的DrawingAttributes引用为我们新创建的DrawingAttributes
            InkCanvas.DefaultDrawingAttributes = drawingAttributes;
            //设置DrawingAttributes的绘制线条的颜色
            drawingAttributes.Color = Colors.Blue;
        }

        //前台的事件传到后台的逻辑代码
        private void RadioButton_click(object sender, RoutedEventArgs eventArgs)
        {
            if (((RadioButton)sender).Content.ToString() == "绘制墨迹")
            {
                //绘制墨迹
                InkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            }
            else if (((RadioButton)sender).Content.ToString() == "按点擦除")
            {
                //块状擦除
                InkCanvas.EditingMode = InkCanvasEditingMode.EraseByPoint;
            }
            else if (((RadioButton)sender).Content.ToString() == "按线擦除")
            {
                //线条擦除
                InkCanvas.EditingMode = InkCanvasEditingMode.EraseByStroke;
            }
            else if (((RadioButton)sender).Content.ToString() == "选中墨迹")
            {
                //选中操作
                InkCanvas.EditingMode = InkCanvasEditingMode.Select;
            }
            else if (((RadioButton)sender).Content.ToString() == "停止操作")
            {
                //不进行任何操作
                InkCanvas.EditingMode = InkCanvasEditingMode.None;
            }
        }
    }
}
