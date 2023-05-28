using System.ComponentModel;
using LanguageEditor.Models;

namespace LanguageEditor.Views
{
    public interface IEditingForm
    {
        BindingList<Attribute> Attributes { get; }
    }
}