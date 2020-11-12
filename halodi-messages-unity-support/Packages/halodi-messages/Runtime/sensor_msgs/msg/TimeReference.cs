using System.Text;
namespace sensor_msgs.msg
{


/**
       * Measurement from an external time source not actively synchronized with the system clock.
       * frame_id is not used
       */
[System.Serializable]
public class TimeReference
{
   /**
            * stamp is system time for which measurement was valid
            */
   public std_msgs.msg.Header header;
   /**
            * corresponding time from this external source
            */
   public builtin_interfaces.msg.Time time_ref;
   /**
            * (optional) name of time source
            *
            * NOTE: Renamed from "source" to avoid conflicts with the Packet<> class in the IHMC ROS2 library
            */
   public string timeSource;


   public void Set(TimeReference other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      builtin_interfaces.msg.TimePubSubType.Copy(other.time_ref, time_ref);

      timeSource = other.timeSource;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("TimeReference {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("time_ref=");
      builder.Append(this.time_ref);      builder.Append(", ");
      builder.Append("timeSource=");
      builder.Append(this.timeSource);
      builder.Append("}");
      return builder.ToString();
   }
}


}