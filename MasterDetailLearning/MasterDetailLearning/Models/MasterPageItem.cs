using MasterDetailLearning.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterDetailLearning.Models
{
    public class MasterPageItem
    {
        public MasterPageItem()
        {
            TargetType = typeof(DetailView);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string IconSource { get; set; }
        public Type TargetType { get; set; }
    }
}
