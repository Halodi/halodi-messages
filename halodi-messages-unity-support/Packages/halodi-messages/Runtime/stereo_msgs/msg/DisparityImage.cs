using System.Text;
namespace stereo_msgs.msg
{


[System.Serializable]
public class DisparityImage
{
   /**
            * Separate header for compatibility with current TimeSynchronizer.
            * Likely to be removed in a later release, use image.header instead.
            */
   public std_msgs.msg.Header header;
   /**
            * Floating point disparity image. The disparities are pre-adjusted for any
            * x-offset between the principal points of the two cameras (in the case
            * that they are verged). That is: d = x_l - x_r - (cx_l - cx_r)
            */
   public sensor_msgs.msg.Image image;
   /**
            * Stereo geometry. For disparity d, the depth from the camera is Z = fT/d.
            * Focal length, pixels
            */
   public float f;
   /**
            * Baseline, world units
            */
   public float t;
   /**
            * Subwindow of (potentially) valid disparity values.
            */
   public sensor_msgs.msg.RegionOfInterest valid_window;
   /**
            * The range of disparities searched.
            * In the disparity image, any disparity less than min_disparity is invalid.
            * The disparity search range defines the horopter, or 3D volume that the
            * stereo algorithm can "see". Points with Z outside of:
            * Z_min = fT / max_disparity
            * Z_max = fT / min_disparity
            * could not be found.
            */
   public float min_disparity;
   public float max_disparity;
   /**
            * Smallest allowed disparity increment. The smallest achievable depth range
            * resolution is delta_Z = (Z^2/fT)*delta_d.
            */
   public float delta_d;


   public void Set(DisparityImage other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      sensor_msgs.msg.ImagePubSubType.Copy(other.image, image);

      f = other.f;

      t = other.t;

      sensor_msgs.msg.RegionOfInterestPubSubType.Copy(other.valid_window, valid_window);

      min_disparity = other.min_disparity;

      max_disparity = other.max_disparity;

      delta_d = other.delta_d;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("DisparityImage {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("image=");
      builder.Append(this.image);      builder.Append(", ");
      builder.Append("f=");
      builder.Append(this.f);      builder.Append(", ");
      builder.Append("t=");
      builder.Append(this.t);      builder.Append(", ");
      builder.Append("valid_window=");
      builder.Append(this.valid_window);      builder.Append(", ");
      builder.Append("min_disparity=");
      builder.Append(this.min_disparity);      builder.Append(", ");
      builder.Append("max_disparity=");
      builder.Append(this.max_disparity);      builder.Append(", ");
      builder.Append("delta_d=");
      builder.Append(this.delta_d);
      builder.Append("}");
      return builder.ToString();
   }
}


}