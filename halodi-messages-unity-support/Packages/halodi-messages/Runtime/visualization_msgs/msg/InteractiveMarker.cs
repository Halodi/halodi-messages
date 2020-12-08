using System.Text;
namespace visualization_msgs.msg
{


[System.Serializable]
public class InteractiveMarker : Halodi.CDR.DataType<InteractiveMarker>
{

	public Halodi.CDR.TopicDataType<InteractiveMarker> Type => new InteractiveMarkerPubSubType();
	
   /**
            * Time/frame info.
            * If header.time is set to 0, the marker will be retransformed into
            * its frame on each timestep. You will receive the pose feedback
            * in the same frame.
            * Otherwise, you might receive feedback in a different frame.
            * For rviz, this will be the current 'fixed frame' set by the user.
            */
   public std_msgs.msg.Header header;
   /**
            * Initial pose. Also, defines the pivot point for rotations.
            */
   public geometry_msgs.msg.Pose pose;
   /**
            * Identifying string. Must be globally unique in
            * the topic that this message is sent through.
            */
   public string name;
   /**
            * Short description (< 40 characters).
            */
   public string description;
   /**
            * Scale to be used for default controls (default=1).
            */
   public float scale;
   /**
            * All menu and submenu entries associated with this marker.
            */
   public System.Collections.Generic.List<visualization_msgs.msg.MenuEntry> menu_entries;
   /**
            * List of controls displayed for this marker.
            */
   public System.Collections.Generic.List<visualization_msgs.msg.InteractiveMarkerControl> controls;


   public void Set(InteractiveMarker other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      geometry_msgs.msg.PosePubSubType.Copy(other.pose, pose);

      name = other.name;

      description = other.description;

      scale = other.scale;


      if(other.menu_entries == null)
      {
      	menu_entries = null;
      }
      else
      {
      	menu_entries = new System.Collections.Generic.List<visualization_msgs.msg.MenuEntry>(other.menu_entries.Count);
      	for(int i1 = 0; i1 < other.menu_entries.Count; i1++)
      	{
      		if(other.menu_entries[i1] == null)
      		{
      			menu_entries.Add(null);
      		}
      		else
      		{
      			visualization_msgs.msg.MenuEntry newElement = visualization_msgs.msg.MenuEntryPubSubType.Create();
      	   		visualization_msgs.msg.MenuEntryPubSubType.Copy(other.menu_entries[i1], newElement);
      	   		menu_entries.Add(newElement);
      		}	}
      }

      if(other.controls == null)
      {
      	controls = null;
      }
      else
      {
      	controls = new System.Collections.Generic.List<visualization_msgs.msg.InteractiveMarkerControl>(other.controls.Count);
      	for(int i2 = 0; i2 < other.controls.Count; i2++)
      	{
      		if(other.controls[i2] == null)
      		{
      			controls.Add(null);
      		}
      		else
      		{
      			visualization_msgs.msg.InteractiveMarkerControl newElement = visualization_msgs.msg.InteractiveMarkerControlPubSubType.Create();
      	   		visualization_msgs.msg.InteractiveMarkerControlPubSubType.Copy(other.controls[i2], newElement);
      	   		controls.Add(newElement);
      		}	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("InteractiveMarker {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("pose=");
      builder.Append(this.pose);      builder.Append(", ");
      builder.Append("name=");
      builder.Append(this.name);      builder.Append(", ");
      builder.Append("description=");
      builder.Append(this.description);      builder.Append(", ");
      builder.Append("scale=");
      builder.Append(this.scale);      builder.Append(", ");
      builder.Append("menu_entries=");
      builder.Append(this.menu_entries);      builder.Append(", ");
      builder.Append("controls=");
      builder.Append(this.controls);
      builder.Append("}");
      return builder.ToString();
   }
}


}