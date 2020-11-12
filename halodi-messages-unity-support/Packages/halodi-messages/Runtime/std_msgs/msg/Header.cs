using System.Text;
namespace std_msgs.msg
{


/**
       * Standard metadata for higher-level stamped data types.
       * This is generally used to communicate timestamped data
       * in a particular coordinate frame.
       */
[System.Serializable]
public class Header
{
   /**
            * Two-integer timestamp that is expressed as seconds and nanoseconds.
            */
   public builtin_interfaces.msg.Time stamp;
   /**
            * Transform frame with which this data is associated.
            */
   public string frame_id;


   public void Set(Header other)
   {
      builtin_interfaces.msg.TimePubSubType.Copy(other.stamp, stamp);

      frame_id = other.frame_id;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Header {");
      builder.Append("stamp=");
      builder.Append(this.stamp);      builder.Append(", ");
      builder.Append("frame_id=");
      builder.Append(this.frame_id);
      builder.Append("}");
      return builder.ToString();
   }
}


}