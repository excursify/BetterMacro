using Dalamud.Interface.Windowing;
using ImGuiNET;
using System.Numerics;

namespace BetterMacro
{
    public class PluginWindow : Window
    {
        public PluginWindow() : base("Better Macro")
        {
            IsOpen = true;
            Size = new Vector2(810, 520);
            SizeCondition = ImGuiCond.FirstUseEver;
        }

        public override void Draw()
        {
            ImGui.Text("Raids");
            // Left Window
            var selected = 0;
            string[] raidArray = 
            {
             "P1S",
             "P2S",
             "P3S",
             "P4S"   
            };
            ImGui.BeginChild("##left_pane", new Vector2(200,425), true);
            if (ImGui.CollapsingHeader("Asphodelos (Savage)")) 
            {
                for (var i = 0 ; i<4 ; i++)
                {
                    var testVar = selected == i ? true : false;
                    if (ImGui.Selectable($"P{i+1}S", selected == i))
                    {
                        selected = i;
                    }
                }
            }
            ImGui.EndChild();
            ImGui.SameLine();
            // Right window
            ImGui.BeginGroup();
            ImGui.BeginChild("##right_window", new Vector2(0, -ImGui.GetFrameHeightWithSpacing()));
            if (selected == 0)
            {
                ImGui.Text("P1S macro");
            }

            if (selected == 1) 
            {
                ImGui.Text("P2S Macro");
            }

            if (selected == 2)
            {
                ImGui.Text("P3S Macro");
            }
            ImGui.EndChild();
            ImGui.EndGroup();

            
        }

        public void DrawRaidStratOptions()
        {
            ImGui.BeginChild("Raid strat");
            ImGui.EndChild();
        }

        public void DrawRaidMechOptions()
        {
            ImGui.BeginChild("Raid Mech");
            ImGui.EndChild();
        }
    }
}
