using System.Text;
namespace sensor_msgs.msg
{


/**
       * Single scan from a planar laser range-finder
       * 
       * If you have another ranging device with different behavior (e.g. a sonar
       * array), please find or create a different message, since applications
       * will make fairly laser-specific assumptions about this data
       * the first ray in the scan.
       * 
       * in frame frame_id, angles are measured around
       * the positive Z axis (counterclockwise, if Z is up)
       * with zero angle being forward along the x axis
       */
[System.Serializable]
public class LaserScan
{
   /**
            * timestamp in the header is the acquisition time of
            */
   public std_msgs.msg.Header header;
   /**
            * start angle of the scan [rad]
            */
   public float angle_min;
   /**
            * end angle of the scan [rad]
            */
   public float angle_max;
   /**
            * angular distance between measurements [rad]
            */
   public float angle_increment;
   /**
            * time between measurements [seconds] - if your scanner
            */
   public float time_increment;
   /**
            * is moving, this will be used in interpolating position
            * of 3d points
            * time between scans [seconds]
            */
   public float scan_time;
   /**
            * minimum range value [m]
            */
   public float range_min;
   /**
            * maximum range value [m]
            */
   public float range_max;
   /**
            * range data [m]
            */
   public System.Collections.Generic.List<float> ranges;
   /**
            * (Note: values < range_min or > range_max should be discarded)
            * intensity data [device-specific units].  If your
            */
   public System.Collections.Generic.List<float> intensities;


   public void Set(LaserScan other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      angle_min = other.angle_min;

      angle_max = other.angle_max;

      angle_increment = other.angle_increment;

      time_increment = other.time_increment;

      scan_time = other.scan_time;

      range_min = other.range_min;

      range_max = other.range_max;


      if(other.ranges == null)
      {
      	ranges = null;
      }
      else
      {
      	ranges = new System.Collections.Generic.List<float>(other.ranges.Count);
      	for(int i1 = 0; i1 < other.ranges.Count; i1++)
      	{
         		ranges.Add(other.ranges[i1]);
      	}
      }

      if(other.intensities == null)
      {
      	intensities = null;
      }
      else
      {
      	intensities = new System.Collections.Generic.List<float>(other.intensities.Count);
      	for(int i2 = 0; i2 < other.intensities.Count; i2++)
      	{
         		intensities.Add(other.intensities[i2]);
      	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("LaserScan {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("angle_min=");
      builder.Append(this.angle_min);      builder.Append(", ");
      builder.Append("angle_max=");
      builder.Append(this.angle_max);      builder.Append(", ");
      builder.Append("angle_increment=");
      builder.Append(this.angle_increment);      builder.Append(", ");
      builder.Append("time_increment=");
      builder.Append(this.time_increment);      builder.Append(", ");
      builder.Append("scan_time=");
      builder.Append(this.scan_time);      builder.Append(", ");
      builder.Append("range_min=");
      builder.Append(this.range_min);      builder.Append(", ");
      builder.Append("range_max=");
      builder.Append(this.range_max);      builder.Append(", ");
      builder.Append("ranges=");
      builder.Append(this.ranges);      builder.Append(", ");
      builder.Append("intensities=");
      builder.Append(this.intensities);
      builder.Append("}");
      return builder.ToString();
   }
}


}