using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicLayer
{
    public class Validator
    {


        TextBox Field { get; set; }
        ComboBox Box;
        string FieldName { get; set; }
        string Message { get; set; }
        string Dublett { get; set; }

        public Validator(ComboBox box, string message)
        {
            Box = box;
            Message = message;
        }


        public Validator(TextBox field, string fieldName, string message)
        {
            Message = message;
            Field = field;
            FieldName = fieldName;
        }

        public virtual DialogResult ErrorMessage()
        {
            FieldName = FieldName;
            string meddelande = FieldName + Message;
            string typ = "Input error";
            MessageBoxButtons button = MessageBoxButtons.OK;

            DialogResult result;

            result = MessageBox.Show(meddelande, typ, button);

            return result;
        }

        public bool isFieldEmpty()
        {

            if (Field.Text.Length==0)
            {
                ErrorMessage();
                return true;
            }
            else return false;
        }

        public bool isBoxEmpty()
        {

            if (Box.Text.Length == 0)
            {
                ErrorMessage();
                return true;
            }

            else return false;


        }






    }
}
