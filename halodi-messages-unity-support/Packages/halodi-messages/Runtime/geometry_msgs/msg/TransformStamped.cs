using System.Text;
namespace geometry_msgs.msg
{


/**
       * This expresses a transform from coordinate frame header.frame_id
       * to the coordinate frame child_frame_id
       * 
       * This message is mostly used by the
       * <a href="http://www.ros.org/wiki/tf">tf</a> package.
       * See its documentation for more information.
       */
[System.Serializable]
public class TransformStamped : Halodi.CDR.DataType<TransformStamped>
{

	public Halodi.CDR.TopicDataType<TransformStamped> Type => new TransformStampedPubSubType();
	
   public std_msgs.msg.Header header;
   /**
            * the frame id of the child frame
            */
   public string child_frame_id;
   public geometry_msgs.msg.Transform transform;


   public void Set(TransformStamped other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      child_frame_id = other.child_frame_id;

      geometry_msgs.msg.TransformPubSubType.Copy(other.transform, transform);

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("TransformStamped {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("child_frame_id=");
      builder.Append(this.child_frame_id);      builder.Append(", ");
      builder.Append("transform=");
      builder.Append(this.transform);
      builder.Append("}");
      return builder.ToString();
   }
}


}