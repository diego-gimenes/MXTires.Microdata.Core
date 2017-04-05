using System;
namespace MXTires.Microdata.Core.CreativeWorks
{
    interface IBook
    {
        string BookEdition { get; set; }
        MXTires.Microdata.Core.Intangible.Enumeration.BookFormatType BookFormat { get; set; }
        MXTires.Microdata.Core.Person Illustrator { get; set; }
        MXTires.Microdata.Core.Person Isbn { get; set; }
        int? NumberOfPages { get; set; }
    }
}
