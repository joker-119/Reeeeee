﻿using System;
using Smod2.Commands;

namespace SCP575
{
    public class SCP575Command : ICommandHandler
    {
        public string GetCommandDescription()
        {
            return "";
        }

        public string GetUsage()
        {
            return "SCP575 Commands \n"+
            "[SCP575 / 575] HELP \n"+
            "SCP575 TOGGLE \n"+
            "SCP575 ENABLE \n"+
            "SCP575 DISABLE \n"+
            "SCP575 ANOFF \n"+
            "SCP575 ANON \n";
        }

        public string[] OnCall(ICommandSender sender, string[] args)
        {
            if (args.Length > 0)
            {
                switch (args[0].ToLower())
                {
                    case "help":
                        return new string[]
                        {
                            "SCP575 Command List \n"+
                            "SCP575 toggle - Toggles a manual SCP-575 on/off. \n"+
                            "SCP575 enable - Enables timed SCP-575 events. \n"+
                            "SCP575 disable - Disables timed SCP-575 events. \n"+
                            "SCP575 anon - Enables CASSIE announcements for events. \n"+
                            "SCP575 anoff - Disables CASSIE announcements for events. \n"
                        };
                    case "toggle":
                    {
                        Functions.ToggleBlackout();
                        return new string[] 
                        { 
                            "Manual SCP-575 event toggled." 
                        };
                    }
                    case "enable":
                    {
                        Functions.EnableBlackouts();
                        return new string[]
                        {
                            "Timed events enabled."
                        };
                    }
                    case "disable":
                    {
                        Functions.DisableBlackouts();
                        return new string[]
                        {
                            "Timed events disabled."
                        };
                    }
                    case "anoff":
                    {
                        Functions.DisableAnnounce();
                        return new string[]
                        {
                            "CASSIE Announcements disabled."
                        };
                    }
                    case "anon":
                    {
                        Functions.EnableAnnounce();
                        return new string[]
                        {
                            "CASSIE Announcements enabled."
                        };
                    }
                    default:
                    {
                        return new string[]
                        {
                            GetUsage()
                        };
                    }
                }
            }
            else
            {
                return new string[]
                {
                    GetUsage()
                };
            }
        }
    }
}