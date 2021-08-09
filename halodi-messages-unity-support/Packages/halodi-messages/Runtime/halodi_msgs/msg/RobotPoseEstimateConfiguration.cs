using System.Text;
namespace halodi_msgs.msg
{


/**
          * Configuration for pose estimates of the robot
          * 
          * This sets up the map to pelvis pose estimator in the controller
          *
          */
[System.Serializable]
public class RobotPoseEstimateConfiguration : Halodi.CDR.DataType<RobotPoseEstimateConfiguration>
{

	public Halodi.CDR.TopicDataType<RobotPoseEstimateConfiguration> Type => new RobotPoseEstimateConfigurationPubSubType();
	
   /**
                * Parent frame: Parent frame of this pose estimate, to which the sensor is statically attached
                *
                * Valid options are all frames that are "Controllable"
                *
                */
   public halodi_msgs.msg.ReferenceFrameName parent_frame;
   /**
                * Transform from static frame to the sensor
                *
                */
   public geometry_msgs.msg.Transform static_transform;
   /**
                * Filtering alpha for the complimentary filter.
                * 
                * A low value (0.01) would be a good initial estimate.
                */
   public double alpha;


   public void Set(RobotPoseEstimateConfiguration other)
   {
      halodi_msgs.msg.ReferenceFrameNamePubSubType.Copy(other.parent_frame, parent_frame);

      geometry_msgs.msg.TransformPubSubType.Copy(other.static_transform, static_transform);

      alpha = other.alpha;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("RobotPoseEstimateConfiguration {");
      builder.Append("parent_frame=");
      builder.Append(this.parent_frame);      builder.Append(", ");
      builder.Append("static_transform=");
      builder.Append(this.static_transform);      builder.Append(", ");
      builder.Append("alpha=");
      builder.Append(this.alpha);
      builder.Append("}");
      return builder.ToString();
   }
}


}