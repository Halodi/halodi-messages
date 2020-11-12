using System.Text;
namespace halodi_msgs.msg
{


/**
          * Calibration information for a 1DOF joint.
          *
          */
[System.Serializable]
public class RobotJointCalibrationInfo
{
   public string frame_id;
   public double transmission_ratio;
   public double measurement_offset;


   public void Set(RobotJointCalibrationInfo other)
   {
      frame_id = other.frame_id;

      transmission_ratio = other.transmission_ratio;

      measurement_offset = other.measurement_offset;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("RobotJointCalibrationInfo {");
      builder.Append("frame_id=");
      builder.Append(this.frame_id);      builder.Append(", ");
      builder.Append("transmission_ratio=");
      builder.Append(this.transmission_ratio);      builder.Append(", ");
      builder.Append("measurement_offset=");
      builder.Append(this.measurement_offset);
      builder.Append("}");
      return builder.ToString();
   }
}


}