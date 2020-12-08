using System.Text;
namespace visualization_msgs.msg
{


/**
       * Represents a control that is to be displayed together with an interactive marker
       */
[System.Serializable]
public class InteractiveMarkerControl : Halodi.CDR.DataType<InteractiveMarkerControl>
{

	public Halodi.CDR.TopicDataType<InteractiveMarkerControl> Type => new InteractiveMarkerControlPubSubType();
	
   /**
          * Orientation mode: controls how orientation changes.
          * INHERIT: Follow orientation of interactive marker
          * FIXED: Keep orientation fixed at initial state
          * VIEW_FACING: Align y-z plane with screen (x: forward, y:left, z:up).
          */
   public const byte INHERIT = (byte) 0;
   public const byte FIXED = (byte) 1;
   public const byte VIEW_FACING = (byte) 2;
   /**
          * Interaction mode for this control
          * 
          * NONE: This control is only meant for visualization; no context menu.
          * MENU: Like NONE, but right-click menu is active.
          * BUTTON: Element can be left-clicked.
          * MOVE_AXIS: Translate along local x-axis.
          * MOVE_PLANE: Translate in local y-z plane.
          * ROTATE_AXIS: Rotate around local x-axis.
          * MOVE_ROTATE: Combines MOVE_PLANE and ROTATE_AXIS.
          */
   public const byte NONE = (byte) 0;
   public const byte MENU = (byte) 1;
   public const byte BUTTON = (byte) 2;
   public const byte MOVE_AXIS = (byte) 3;
   public const byte MOVE_PLANE = (byte) 4;
   public const byte ROTATE_AXIS = (byte) 5;
   public const byte MOVE_ROTATE = (byte) 6;
   /**
          * "3D" interaction modes work with the mouse+SHIFT+CTRL or with 3D cursors.
          * MOVE_3D: Translate freely in 3D space.
          * ROTATE_3D: Rotate freely in 3D space about the origin of parent frame.
          * MOVE_ROTATE_3D: Full 6-DOF freedom of translation and rotation about the cursor origin.
          */
   public const byte MOVE_3D = (byte) 7;
   public const byte ROTATE_3D = (byte) 8;
   public const byte MOVE_ROTATE_3D = (byte) 9;
   /**
            * Identifying string for this control.
            * You need to assign a unique value to this to receive feedback from the GUI
            * on what actions the user performs on this control (e.g. a button click).
            */
   public string name;
   /**
            * Defines the local coordinate frame (relative to the pose of the parent
            * interactive marker) in which is being rotated and translated.
            * Default: Identity
            */
   public geometry_msgs.msg.Quaternion orientation;
   public byte orientation_mode;
   public byte interaction_mode;
   /**
            * If true, the contained markers will also be visible
            * when the gui is not in interactive mode.
            */
   public bool always_visible;
   /**
            * Markers to be displayed as custom visual representation.
            * Leave this empty to use the default control handles.
            * 
            * Note:
            * - The markers can be defined in an arbitrary coordinate frame,
            * but will be transformed into the local frame of the interactive marker.
            * - If the header of a marker is empty, its pose will be interpreted as
            * relative to the pose of the parent interactive marker.
            */
   public System.Collections.Generic.List<visualization_msgs.msg.Marker> markers;
   /**
            * In VIEW_FACING mode, set this to true if you don't want the markers
            * to be aligned with the camera view point. The markers will show up
            * as in INHERIT mode.
            */
   public bool independent_marker_orientation;
   /**
            * Short description (< 40 characters) of what this control does,
            * e.g. "Move the robot".
            * Default: A generic description based on the interaction mode
            */
   public string description;


   public void Set(InteractiveMarkerControl other)
   {
      name = other.name;

      geometry_msgs.msg.QuaternionPubSubType.Copy(other.orientation, orientation);

      orientation_mode = other.orientation_mode;

      interaction_mode = other.interaction_mode;

      always_visible = other.always_visible;


      if(other.markers == null)
      {
      	markers = null;
      }
      else
      {
      	markers = new System.Collections.Generic.List<visualization_msgs.msg.Marker>(other.markers.Count);
      	for(int i1 = 0; i1 < other.markers.Count; i1++)
      	{
      		if(other.markers[i1] == null)
      		{
      			markers.Add(null);
      		}
      		else
      		{
      			visualization_msgs.msg.Marker newElement = visualization_msgs.msg.MarkerPubSubType.Create();
      	   		visualization_msgs.msg.MarkerPubSubType.Copy(other.markers[i1], newElement);
      	   		markers.Add(newElement);
      		}	}
      }
      independent_marker_orientation = other.independent_marker_orientation;

      description = other.description;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("InteractiveMarkerControl {");
      builder.Append("name=");
      builder.Append(this.name);      builder.Append(", ");
      builder.Append("orientation=");
      builder.Append(this.orientation);      builder.Append(", ");
      builder.Append("orientation_mode=");
      builder.Append(this.orientation_mode);      builder.Append(", ");
      builder.Append("interaction_mode=");
      builder.Append(this.interaction_mode);      builder.Append(", ");
      builder.Append("always_visible=");
      builder.Append(this.always_visible);      builder.Append(", ");
      builder.Append("markers=");
      builder.Append(this.markers);      builder.Append(", ");
      builder.Append("independent_marker_orientation=");
      builder.Append(this.independent_marker_orientation);      builder.Append(", ");
      builder.Append("description=");
      builder.Append(this.description);
      builder.Append("}");
      return builder.ToString();
   }
}


}