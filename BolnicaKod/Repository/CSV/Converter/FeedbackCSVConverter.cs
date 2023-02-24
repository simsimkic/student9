using bolnica.Model;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolnica.Repository.CSV.Converter
{
    class FeedbackCSVConverter : ICSVConverter<Feedback>
    {

        private readonly string _delimiter;

        public FeedbackCSVConverter(string delimiter)
        {
            _delimiter = delimiter;
        }

        public Feedback KonvertujCSVFormatUEntitet(string CSVFormatEntiteta)
        {
            string[] tokeni = CSVFormatEntiteta.Split(_delimiter.ToCharArray());
            return new Feedback(
                int.Parse(tokeni[0]),
                tokeni[1], new Autor(int.Parse(tokeni[2]))
                );
                
        } 

        public string KonvertujEntitetUSCVFormat(Feedback feedback)
            => string.Join(_delimiter,
                feedback.Id.ToString(),
                feedback.Tekst,
                feedback.Autor.Id.ToString()
                );

       


    }
}
