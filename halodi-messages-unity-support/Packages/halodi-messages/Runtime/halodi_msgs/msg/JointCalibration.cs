using System.Text;
namespace halodi_msgs.msg
{


/**
          * Calibration information for a 1DOF joint.
          *
          */
[System.Serializable]
public class JointCalibration : Halodi.CDR.DataType<JointCalibration>
{

	public Halodi.CDR.TopicDataType<JointCalibration> Type => new JointCalibrationPubSubType();
	
   public string joint_name;
   public double measurement_multiplier;
   public double measurement_bias;


   public void Set(JointCalibration other)
   {
      joint_name = other.joint_name;

      measurement_multiplier = other.measurement_multiplier;

      measurement_bias = other.measurement_bias;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("JointCalibration {");
      builder.Append("joint_name=");
      builder.Append(this.joint_name);      builder.Append(", ");
      builder.Append("measurement_multiplier=");
      builder.Append(this.measurement_multiplier);      builder.Append(", ");
      builder.Append("measurement_bias=");
      builder.Append(this.measurement_bias);
      builder.Append("}");
      return builder.ToString();
   }
}


}