using System;
using System.Windows;
using System.Windows.Controls;


namespace UIMessage
{
    public class MessageDataTemplateSelector : ContentControl
    {
        protected override void OnContentChanged(object oldContent, object newContent)
        {
            base.OnContentChanged(oldContent, newContent);
            
            var item = newContent as Message;
            if (item==null) throw new Exception("Expected datatype is Message");

            // you could load dynamically from a DLL or loose xaml file, here we use an application resource
            var key = string.Format("{0}DataTemplate", item.MessageType);
            var dataTemplate = Application.Current.Resources[key] as DataTemplate;   
             
            ContentTemplate = dataTemplate;
        }
    }
}
