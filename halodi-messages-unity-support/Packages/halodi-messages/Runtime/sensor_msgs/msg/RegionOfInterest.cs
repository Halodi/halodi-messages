using System.Text;
namespace sensor_msgs.msg
{


/**
       * This message is used to specify a region of interest within an image.
       * 
       * When used to specify the ROI setting of the camera when the image was
       * taken, the height and width fields should either match the height and
       * width fields for the associated image; or height = width = 0
       * indicates that the full resolution image was captured.
       */
[System.Serializable]
public class RegionOfInterest
{
   /**
            * Leftmost pixel of the ROI
            */
   public uint x_offset;
   /**
            * (0 if the ROI includes the left edge of the image)
            * Topmost pixel of the ROI
            */
   public uint y_offset;
   /**
            * (0 if the ROI includes the top edge of the image)
            * Height of ROI
            */
   public uint height;
   /**
            * Width of ROI
            */
   public uint width;
   /**
            * True if a distinct rectified ROI should be calculated from the "raw"
            * ROI in this message. Typically this should be False if the full image
            * is captured (ROI not used), and True if a subwindow is captured (ROI
            * used).
            */
   public bool do_rectify;


   public void Set(RegionOfInterest other)
   {
      x_offset = other.x_offset;

      y_offset = other.y_offset;

      height = other.height;

      width = other.width;

      do_rectify = other.do_rectify;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("RegionOfInterest {");
      builder.Append("x_offset=");
      builder.Append(this.x_offset);      builder.Append(", ");
      builder.Append("y_offset=");
      builder.Append(this.y_offset);      builder.Append(", ");
      builder.Append("height=");
      builder.Append(this.height);      builder.Append(", ");
      builder.Append("width=");
      builder.Append(this.width);      builder.Append(", ");
      builder.Append("do_rectify=");
      builder.Append(this.do_rectify);
      builder.Append("}");
      return builder.ToString();
   }
}


}