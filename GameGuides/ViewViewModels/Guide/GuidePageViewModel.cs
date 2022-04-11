using GameGuides.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace GameGuides.ViewViewModels.Guide
{
    class GuidePageViewModel
    {
            public string newName { get; set; }
            public string newInfo { get; set; }
            public string newImage { get; set; }

            //public ImageSource SubmitIcon { get; set; }


            //ObservableCollection<Person> models { get; set; }
            //public GuidePageViewModel()
            //{
            //    newName = "Name";
            //    newInfo = "Info";
            //    newImage = "Image";
            //    //SubmitIcon = ImageSource.FromResource("MyFirstProject.Images.iconssubmit.png");
            //}
            public GuidePageViewModel(GuideModel Game)
            {
                newName = Game.Rules;
                newInfo = Game.Strategies;
                newImage = Game.Title;
                //SubmitIcon = ImageSource.FromResource("MyFirstProject.Images.iconssubmit.png");
                //models = src;
            }


        }

    }
