using System.Text;
namespace sensor_msgs.msg
{


/**
       * Single reading from a relative humidity sensor.
       * Defines the ratio of partial pressure of water vapor to the saturated vapor
       * pressure at a temperature.
       * frame_id is the location of the humidity sensor
       * from 0.0 to 1.0.
       * 0.0 is no partial pressure of water vapor
       * 1.0 represents partial pressure of saturation
       */
[System.Serializable]
public class RelativeHumidity : Halodi.CDR.DataType<RelativeHumidity>
{

	public Halodi.CDR.TopicDataType<RelativeHumidity> Type => new RelativeHumidityPubSubType();
	
   /**
            * timestamp of the measurement
            */
   public std_msgs.msg.Header header;
   /**
            * Expression of the relative humidity
            */
   public double relative_humidity;
   /**
            * 0 is interpreted as variance unknown
            */
   public double variance;


   public void Set(RelativeHumidity other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      relative_humidity = other.relative_humidity;

      variance = other.variance;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("RelativeHumidity {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("relative_humidity=");
      builder.Append(this.relative_humidity);      builder.Append(", ");
      builder.Append("variance=");
      builder.Append(this.variance);
      builder.Append("}");
      return builder.ToString();
   }
}


}