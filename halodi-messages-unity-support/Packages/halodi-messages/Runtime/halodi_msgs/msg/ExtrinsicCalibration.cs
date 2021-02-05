using System.Text;
namespace halodi_msgs.msg
{


/**
          * Extrinsic calibration data.
          *
          */
[System.Serializable]
public class ExtrinsicCalibration : Halodi.CDR.DataType<ExtrinsicCalibration>
{

	public Halodi.CDR.TopicDataType<ExtrinsicCalibration> Type => new ExtrinsicCalibrationPubSubType();
	
   public System.Collections.Generic.List<geometry_msgs.msg.TransformStamped> sensors;
   public System.Collections.Generic.List<geometry_msgs.msg.TransformStamped> links;
   public System.Collections.Generic.List<halodi_msgs.msg.JointCalibration> joints;


   public void Set(ExtrinsicCalibration other)
   {

      if(other.sensors == null)
      {
      	sensors = null;
      }
      else
      {
      	sensors = new System.Collections.Generic.List<geometry_msgs.msg.TransformStamped>(other.sensors.Count);
      	for(int i1 = 0; i1 < other.sensors.Count; i1++)
      	{
      		if(other.sensors[i1] == null)
      		{
      			sensors.Add(null);
      		}
      		else
      		{
      			geometry_msgs.msg.TransformStamped newElement = geometry_msgs.msg.TransformStampedPubSubType.Create();
      	   		geometry_msgs.msg.TransformStampedPubSubType.Copy(other.sensors[i1], newElement);
      	   		sensors.Add(newElement);
      		}	}
      }

      if(other.links == null)
      {
      	links = null;
      }
      else
      {
      	links = new System.Collections.Generic.List<geometry_msgs.msg.TransformStamped>(other.links.Count);
      	for(int i2 = 0; i2 < other.links.Count; i2++)
      	{
      		if(other.links[i2] == null)
      		{
      			links.Add(null);
      		}
      		else
      		{
      			geometry_msgs.msg.TransformStamped newElement = geometry_msgs.msg.TransformStampedPubSubType.Create();
      	   		geometry_msgs.msg.TransformStampedPubSubType.Copy(other.links[i2], newElement);
      	   		links.Add(newElement);
      		}	}
      }

      if(other.joints == null)
      {
      	joints = null;
      }
      else
      {
      	joints = new System.Collections.Generic.List<halodi_msgs.msg.JointCalibration>(other.joints.Count);
      	for(int i3 = 0; i3 < other.joints.Count; i3++)
      	{
      		if(other.joints[i3] == null)
      		{
      			joints.Add(null);
      		}
      		else
      		{
      			halodi_msgs.msg.JointCalibration newElement = halodi_msgs.msg.JointCalibrationPubSubType.Create();
      	   		halodi_msgs.msg.JointCalibrationPubSubType.Copy(other.joints[i3], newElement);
      	   		joints.Add(newElement);
      		}	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("ExtrinsicCalibration {");
      builder.Append("sensors=");
      builder.Append(this.sensors);      builder.Append(", ");
      builder.Append("links=");
      builder.Append(this.links);      builder.Append(", ");
      builder.Append("joints=");
      builder.Append(this.joints);
      builder.Append("}");
      return builder.ToString();
   }
}


}