using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "ExtrinsicCalibration" defined in "ExtrinsicCalibration.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from ExtrinsicCalibration.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit ExtrinsicCalibration.idl instead.
*
*/
public class ExtrinsicCalibrationPubSubType : Halodi.CDR.TopicDataType<ExtrinsicCalibration>
{
   public override string Name => "halodi_msgs::msg::dds_::ExtrinsicCalibration_";


   public static int getCdrSerializedSize(halodi_msgs.msg.ExtrinsicCalibration data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.ExtrinsicCalibration data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.sensors.Count; ++i0)
      {
          current_alignment += geometry_msgs.msg.TransformStampedPubSubType.getCdrSerializedSize(data.sensors[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.links.Count; ++i0)
      {
          current_alignment += geometry_msgs.msg.TransformStampedPubSubType.getCdrSerializedSize(data.links[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.joints.Count; ++i0)
      {
          current_alignment += halodi_msgs.msg.JointCalibrationPubSubType.getCdrSerializedSize(data.joints[i0], current_alignment);}


      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.ExtrinsicCalibration data, Halodi.CDR.CDRSerializer cdr)
   {
      	if(data.sensors == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int sensors_length = data.sensors.Count;
            cdr.write_type_2(sensors_length);
            for (int i0 = 0; i0 < sensors_length; i0++)
            {
      			geometry_msgs.msg.TransformStampedPubSubType.write(data.sensors[i0], cdr);	      }
        }
      	if(data.links == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int links_length = data.links.Count;
            cdr.write_type_2(links_length);
            for (int i0 = 0; i0 < links_length; i0++)
            {
      			geometry_msgs.msg.TransformStampedPubSubType.write(data.links[i0], cdr);	      }
        }
      	if(data.joints == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int joints_length = data.joints.Count;
            cdr.write_type_2(joints_length);
            for (int i0 = 0; i0 < joints_length; i0++)
            {
      			halodi_msgs.msg.JointCalibrationPubSubType.write(data.joints[i0], cdr);	      }
        }
   }

   public static void read(halodi_msgs.msg.ExtrinsicCalibration data, Halodi.CDR.CDRDeserializer cdr)
   {

      int sensors_length = cdr.read_type_2();
      data.sensors = new System.Collections.Generic.List<geometry_msgs.msg.TransformStamped>(sensors_length);
      for(int i = 0; i < sensors_length; i++)
      {
      	geometry_msgs.msg.TransformStamped new_sensors = geometry_msgs.msg.TransformStampedPubSubType.Create(); 
      	geometry_msgs.msg.TransformStampedPubSubType.read(new_sensors, cdr);
      	data.sensors.Add(new_sensors);	
      	
      }

      	

      int links_length = cdr.read_type_2();
      data.links = new System.Collections.Generic.List<geometry_msgs.msg.TransformStamped>(links_length);
      for(int i = 0; i < links_length; i++)
      {
      	geometry_msgs.msg.TransformStamped new_links = geometry_msgs.msg.TransformStampedPubSubType.Create(); 
      	geometry_msgs.msg.TransformStampedPubSubType.read(new_links, cdr);
      	data.links.Add(new_links);	
      	
      }

      	

      int joints_length = cdr.read_type_2();
      data.joints = new System.Collections.Generic.List<halodi_msgs.msg.JointCalibration>(joints_length);
      for(int i = 0; i < joints_length; i++)
      {
      	halodi_msgs.msg.JointCalibration new_joints = halodi_msgs.msg.JointCalibrationPubSubType.Create(); 
      	halodi_msgs.msg.JointCalibrationPubSubType.read(new_joints, cdr);
      	data.joints.Add(new_joints);	
      	
      }

      	

   }


	public override void Serialize(halodi_msgs.msg.ExtrinsicCalibration data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(halodi_msgs.msg.ExtrinsicCalibration data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(halodi_msgs.msg.ExtrinsicCalibration data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(halodi_msgs.msg.ExtrinsicCalibration src, halodi_msgs.msg.ExtrinsicCalibration target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(halodi_msgs.msg.ExtrinsicCalibration src, halodi_msgs.msg.ExtrinsicCalibration target)
    {
    	Copy(src, target);
    }


}


}