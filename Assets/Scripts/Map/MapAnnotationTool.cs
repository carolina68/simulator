/**
 * Copyright (c) 2019-2021 LG Electronics, Inc.
 *
 * This software contains code licensed as described in LICENSE.
 *
 */

using UnityEngine;

namespace Simulator.Map
{
    public class MapAnnotationTool : MonoBehaviour
    {
        public enum CreateMode
        {
            NONE,
            LANE_LINE,
            SIGNAL,
            SIGN,
            POLE,
            PEDESTRIAN,
            JUNCTION,
            CROSSWALK,
            CLEARAREA,
            PARKINGSPACE,
            SPEEDBUMP,
        };
        public static CreateMode createMode { get; set; } = CreateMode.NONE;

        public enum PedestrianPathType
        {
            SIDEWALK,
            CROSSWALK,
        };

        public static bool TOOL_ACTIVE { get; set; } = false;
        public static bool SHOW_HELP { get; set; } = false;
        public static bool SHOW_MAP_ALL { get; set; } = true;
        public static bool SHOW_MAP_SELECTED { get; set; } = false;
        public static float PROXIMITY { get; set; } = 1.0f;
        public static float EXPORT_SCALE_FACTOR = 1.0f;
        public static float ARROWSIZE => 100f * WAYPOINT_SIZE;
        public static float WAYPOINT_SIZE { get; set; } = 0.5f;

        // public bool show_all;
        // public bool show_selected;

        // void Start() {
        //     SHOW_MAP_ALL=show_all;
        //     SHOW_MAP_SELECTED=show_selected;
        // }
    }
}