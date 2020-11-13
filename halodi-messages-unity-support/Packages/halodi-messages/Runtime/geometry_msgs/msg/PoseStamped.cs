using System.Text;
namespace geometry_msgs.msg
{


/**
       * A Pose with reference coordinate frame and timestamp
       */
[System.Serializable]
public class PoseStamped : Halodi.CDR.DataType<PoseStamped>
{

	public Halodi.CDR.TopicDataType<PoseStamped> Type => new PoseStampedPubSubType();
	
   public std_msgs.msg.Header header;
   public geometry_msgs.msg.Pose pose;


   public void Set(PoseStamped other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      geometry_msgs.msg.PosePubSubType.Copy(other.pose, pose);

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("PoseStamped {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("pose=");
      builder.Append(this.pose);
      builder.Append("}");
      return builder.ToString();
   }
}


}