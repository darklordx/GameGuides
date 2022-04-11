using GameGuides.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace GameGuides.ViewViewModels.Guide
{
    class GuidePageViewModel
    {
            public string Rules { get; set; }
            public string Title { get; set; }
            public string Strategies { get; set; }

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
                Rules = Game.Rules;
                Strategies = Game.Strategies;
                Title = Game.Title;
                //SubmitIcon = ImageSource.FromResource("MyFirstProject.Images.iconssubmit.png");
                //models = src;
            }


        }

    }
