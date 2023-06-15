﻿using GymManager.Core.Navigation;

namespace GymManager.Web.Model
{
    public class UserMenuItemViewModel
    {
        public UserMenuItem MenuItem { get; set; }
        public string CurrentPageName { get; set; }
        public int ItemDepth { get; set; }
        public bool RootLevel { get; set; }
    }
}
