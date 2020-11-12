using System.Text;
namespace visualization_msgs.msg
{


/**
       * Feedback message sent back from the GUI, e.g.
       * when the status of an interactive marker was modified by the user.
       */
[System.Serializable]
public class InteractiveMarkerFeedback
{
   /**
          * Type of the event
          * KEEP_ALIVE: sent while dragging to keep up control of the marker
          * MENU_SELECT: a menu entry has been selected
          * BUTTON_CLICK: a button control has been clicked
          * POSE_UPDATE: the pose has been changed using one of the controls
          */
   public const byte KEEP_ALIVE = (byte) 0;
   public const byte POSE_UPDATE = (byte) 1;
   public const byte MENU_SELECT = (byte) 2;
   public const byte BUTTON_CLICK = (byte) 3;
   public const byte MOUSE_DOWN = (byte) 4;
   public const byte MOUSE_UP = (byte) 5;
   /**
            * Time/frame info.
            */
   public std_msgs.msg.Header header;
   /**
            * Identifying string. Must be unique in the topic namespace.
            */
   public string client_id;
   /**
            * Specifies which interactive marker and control this message refers to
            */
   public string marker_name;
   public string control_name;
   public byte event_type;
   /**
            * Current pose of the marker
            * Note: Has to be valid for all feedback types.
            */
   public geometry_msgs.msg.Pose pose;
   /**
            * Contains the ID of the selected menu entry
            * Only valid for MENU_SELECT events.
            */
   public uint menu_entry_id;
   /**
            * If event_type is BUTTON_CLICK, MOUSE_DOWN, or MOUSE_UP, mouse_point
            * may contain the 3 dimensional position of the event on the
            * control.  If it does, mouse_point_valid will be true.  mouse_point
            * will be relative to the frame listed in the header.
            */
   public geometry_msgs.msg.Point mouse_point;
   public bool mouse_point_valid;


   public void Set(InteractiveMarkerFeedback other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      client_id = other.client_id;

      marker_name = other.marker_name;

      control_name = other.control_name;

      event_type = other.event_type;

      geometry_msgs.msg.PosePubSubType.Copy(other.pose, pose);

      menu_entry_id = other.menu_entry_id;

      geometry_msgs.msg.PointPubSubType.Copy(other.mouse_point, mouse_point);

      mouse_point_valid = other.mouse_point_valid;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("InteractiveMarkerFeedback {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("client_id=");
      builder.Append(this.client_id);      builder.Append(", ");
      builder.Append("marker_name=");
      builder.Append(this.marker_name);      builder.Append(", ");
      builder.Append("control_name=");
      builder.Append(this.control_name);      builder.Append(", ");
      builder.Append("event_type=");
      builder.Append(this.event_type);      builder.Append(", ");
      builder.Append("pose=");
      builder.Append(this.pose);      builder.Append(", ");
      builder.Append("menu_entry_id=");
      builder.Append(this.menu_entry_id);      builder.Append(", ");
      builder.Append("mouse_point=");
      builder.Append(this.mouse_point);      builder.Append(", ");
      builder.Append("mouse_point_valid=");
      builder.Append(this.mouse_point_valid);
      builder.Append("}");
      return builder.ToString();
   }
}


}