using System.Text;
namespace sensor_msgs.msg
{


/**
       * Single temperature reading.
       * frame_id is the location of the temperature reading
       */
[System.Serializable]
public class Temperature
{
   /**
            * timestamp is the time the temperature was measured
            */
   public std_msgs.msg.Header header;
   /**
            * Measurement of the Temperature in Degrees Celsius.
            */
   public double temperature;
   /**
            * 0 is interpreted as variance unknown.
            */
   public double variance;


   public void Set(Temperature other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      temperature = other.temperature;

      variance = other.variance;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Temperature {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("temperature=");
      builder.Append(this.temperature);      builder.Append(", ");
      builder.Append("variance=");
      builder.Append(this.variance);
      builder.Append("}");
      return builder.ToString();
   }
}


}