using System.Text;
namespace builtin_interfaces.msg
{


[System.Serializable]
public class Time : Halodi.CDR.DataType<Time>
{

	public Halodi.CDR.TopicDataType<Time> Type => new TimePubSubType();
	
   public int sec;
   public uint nanosec;


   public void Set(Time other)
   {
      sec = other.sec;

      nanosec = other.nanosec;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Time {");
      builder.Append("sec=");
      builder.Append(this.sec);      builder.Append(", ");
      builder.Append("nanosec=");
      builder.Append(this.nanosec);
      builder.Append("}");
      return builder.ToString();
   }
}


}