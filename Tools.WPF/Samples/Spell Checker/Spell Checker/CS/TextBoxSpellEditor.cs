﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Syncfusion.Windows.Shared;

namespace SpellCheckerDemo
{
    public class TextBoxSpellEditor: ISpellEditor
    {
        private TextBox textBox;
        public TextBoxSpellEditor(Control control)
        {
            ControlToCheck = control;
        }

        public Control ControlToCheck
        {
            get
            {
                return textBox;
            }
            set
            {
                textBox = value as TextBox;
            }
        }

        public string SelectedText
        {
            get
            {
                return textBox.SelectedText;
            }
            set
            {
                textBox.SelectedText = value;
            }
        }

        public string Text
        {
            get
            {
                return textBox.Text;
            }
            set
            {
                textBox.Text = value;
            }
        }

        public void Select(int selectionStart, int selectionLength)
        {
            textBox.Select(selectionStart, selectionLength);
        }

        public bool HasMoreTextToCheck()
        {
            return false;
        }

        public void Focus()
        {
            textBox.Focus();
        }


        #region ISpellEditor Members


        public void UpdateTextField()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
