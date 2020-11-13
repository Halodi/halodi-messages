using System.Text;
namespace rosgraph_msgs.msg
{


[System.Serializable]
public class Clock : Halodi.CDR.DataType<Clock>
{

	public Halodi.CDR.TopicDataType<Clock> Type => new ClockPubSubType();
	
   /**
            * This message simply communicates the current time.
            * For more information, see http://www.ros.org/wiki/Clock
            */
   public builtin_interfaces.msg.Time clock;


   public void Set(Clock other)
   {
      builtin_interfaces.msg.TimePubSubType.Copy(other.clock, clock);
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Clock {");
      builder.Append("clock=");
      builder.Append(this.clock);
      builder.Append("}");
      return builder.ToString();
   }
}


}