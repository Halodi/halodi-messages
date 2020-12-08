using System.Text;
namespace sensor_msgs.msg
{


/**
       * Single range reading from an active ranger that emits energy and reports
       * one range reading that is valid along an arc at the distance measured.
       * This message is  not appropriate for laser scanners. See the LaserScan
       * message if you are working with a laser scanner.
       * 
       * This message also can represent a fixed-distance (binary) ranger.  This
       * sensor will have min_range===max_range===distance of detection.
       * These sensors follow REP 117 and will output -Inf if the object is detected
       * and +Inf if the object is outside of the detection range.
       * returned the distance reading
       * (sound, IR, etc) [enum]
       * valid for [rad]
       * the object causing the range reading may have
       * been anywhere within -field_of_view/2 and
       * field_of_view/2 at the measured range.
       * 0 angle corresponds to the x-axis of the sensor.
       * Fixed distance rangers require min_range==max_range
       */
[System.Serializable]
public class Range : Halodi.CDR.DataType<Range>
{

	public Halodi.CDR.TopicDataType<Range> Type => new RangePubSubType();
	
   /**
          * Radiation type enums
          * If you want a value added to this list, send an email to the ros-users list
          */
   public const byte ULTRASOUND = (byte) 0;
   public const byte INFRARED = (byte) 1;
   /**
            * timestamp in the header is the time the ranger
            */
   public std_msgs.msg.Header header;
   /**
            * the type of radiation used by the sensor
            */
   public byte radiation_type;
   /**
            * the size of the arc that the distance reading is
            */
   public float field_of_view;
   /**
            * minimum range value [m]
            */
   public float min_range;
   /**
            * maximum range value [m]
            */
   public float max_range;
   /**
            * range data [m]
            */
   public float range;


   public void Set(Range other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      radiation_type = other.radiation_type;

      field_of_view = other.field_of_view;

      min_range = other.min_range;

      max_range = other.max_range;

      range = other.range;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Range {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("radiation_type=");
      builder.Append(this.radiation_type);      builder.Append(", ");
      builder.Append("field_of_view=");
      builder.Append(this.field_of_view);      builder.Append(", ");
      builder.Append("min_range=");
      builder.Append(this.min_range);      builder.Append(", ");
      builder.Append("max_range=");
      builder.Append(this.max_range);      builder.Append(", ");
      builder.Append("range=");
      builder.Append(this.range);
      builder.Append("}");
      return builder.ToString();
   }
}


}