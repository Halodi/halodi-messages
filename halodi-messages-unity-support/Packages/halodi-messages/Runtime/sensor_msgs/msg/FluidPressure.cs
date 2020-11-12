using System.Text;
namespace sensor_msgs.msg
{


/**
       * Single pressure reading.  This message is appropriate for measuring the
       * pressure inside of a fluid (air, water, etc).  This also includes
       * atmospheric or barometric pressure.
       * 
       * This message is not appropriate for force/pressure contact sensors.
       * frame_id is the location of the pressure sensor
       */
[System.Serializable]
public class FluidPressure
{
   /**
            * timestamp of the measurement
            */
   public std_msgs.msg.Header header;
   /**
            * Absolute pressure reading in Pascals.
            */
   public double fluid_pressure;
   /**
            * 0 is interpreted as variance unknown
            */
   public double variance;


   public void Set(FluidPressure other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      fluid_pressure = other.fluid_pressure;

      variance = other.variance;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("FluidPressure {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("fluid_pressure=");
      builder.Append(this.fluid_pressure);      builder.Append(", ");
      builder.Append("variance=");
      builder.Append(this.variance);
      builder.Append("}");
      return builder.ToString();
   }
}


}