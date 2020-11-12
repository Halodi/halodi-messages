using System.Text;
namespace visualization_msgs.msg
{


[System.Serializable]
public class InteractiveMarkerPose
{
   /**
            * Time/frame info.
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


   public void Set(InteractiveMarkerPose other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      geometry_msgs.msg.PosePubSubType.Copy(other.pose, pose);

      name = other.name;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("InteractiveMarkerPose {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("pose=");
      builder.Append(this.pose);      builder.Append(", ");
      builder.Append("name=");
      builder.Append(this.name);
      builder.Append("}");
      return builder.ToString();
   }
}


}