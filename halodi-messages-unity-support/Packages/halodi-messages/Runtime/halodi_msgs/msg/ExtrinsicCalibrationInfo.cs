using System.Text;
namespace halodi_msgs.msg
{


/**
          * Extrinsic calibration data.
          *
          */
[System.Serializable]
public class ExtrinsicCalibrationInfo
{
   public System.Collections.Generic.List<geometry_msgs.msg.TransformStamped> sensor_transforms;
   public System.Collections.Generic.List<geometry_msgs.msg.TransformStamped> link_infos;
   public System.Collections.Generic.List<halodi_msgs.msg.RobotJointCalibrationInfo> joint_infos;


   public void Set(ExtrinsicCalibrationInfo other)
   {

      if(other.sensor_transforms == null)
      {
      	sensor_transforms = null;
      }
      else
      {
      	sensor_transforms = new System.Collections.Generic.List<geometry_msgs.msg.TransformStamped>(other.sensor_transforms.Count);
      	for(int i1 = 0; i1 < other.sensor_transforms.Count; i1++)
      	{
      		if(other.sensor_transforms[i1] == null)
      		{
      			sensor_transforms.Add(null);
      		}
      		else
      		{
      			geometry_msgs.msg.TransformStamped newElement = geometry_msgs.msg.TransformStampedPubSubType.Create();
      	   		geometry_msgs.msg.TransformStampedPubSubType.Copy(other.sensor_transforms[i1], newElement);
      	   		sensor_transforms.Add(newElement);
      		}	}
      }

      if(other.link_infos == null)
      {
      	link_infos = null;
      }
      else
      {
      	link_infos = new System.Collections.Generic.List<geometry_msgs.msg.TransformStamped>(other.link_infos.Count);
      	for(int i2 = 0; i2 < other.link_infos.Count; i2++)
      	{
      		if(other.link_infos[i2] == null)
      		{
      			link_infos.Add(null);
      		}
      		else
      		{
      			geometry_msgs.msg.TransformStamped newElement = geometry_msgs.msg.TransformStampedPubSubType.Create();
      	   		geometry_msgs.msg.TransformStampedPubSubType.Copy(other.link_infos[i2], newElement);
      	   		link_infos.Add(newElement);
      		}	}
      }

      if(other.joint_infos == null)
      {
      	joint_infos = null;
      }
      else
      {
      	joint_infos = new System.Collections.Generic.List<halodi_msgs.msg.RobotJointCalibrationInfo>(other.joint_infos.Count);
      	for(int i3 = 0; i3 < other.joint_infos.Count; i3++)
      	{
      		if(other.joint_infos[i3] == null)
      		{
      			joint_infos.Add(null);
      		}
      		else
      		{
      			halodi_msgs.msg.RobotJointCalibrationInfo newElement = halodi_msgs.msg.RobotJointCalibrationInfoPubSubType.Create();
      	   		halodi_msgs.msg.RobotJointCalibrationInfoPubSubType.Copy(other.joint_infos[i3], newElement);
      	   		joint_infos.Add(newElement);
      		}	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("ExtrinsicCalibrationInfo {");
      builder.Append("sensor_transforms=");
      builder.Append(this.sensor_transforms);      builder.Append(", ");
      builder.Append("link_infos=");
      builder.Append(this.link_infos);      builder.Append(", ");
      builder.Append("joint_infos=");
      builder.Append(this.joint_infos);
      builder.Append("}");
      return builder.ToString();
   }
}


}