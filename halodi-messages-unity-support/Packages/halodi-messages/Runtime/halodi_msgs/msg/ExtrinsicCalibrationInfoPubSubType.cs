using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "ExtrinsicCalibrationInfo" defined in "ExtrinsicCalibrationInfo.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from ExtrinsicCalibrationInfo.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit ExtrinsicCalibrationInfo.idl instead.
*
*/
public class ExtrinsicCalibrationInfoPubSubType : Halodi.CDR.TopicDataType<ExtrinsicCalibrationInfo>
{
   public override string Name => "halodi_msgs::msg::dds_::ExtrinsicCalibrationInfo_";


   
   public override void serialize(halodi_msgs.msg.ExtrinsicCalibrationInfo data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, halodi_msgs.msg.ExtrinsicCalibrationInfo data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.ExtrinsicCalibrationInfo data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.ExtrinsicCalibrationInfo data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.sensor_transforms.Count; ++i0)
      {
          current_alignment += geometry_msgs.msg.TransformStampedPubSubType.getCdrSerializedSize(data.sensor_transforms[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.link_infos.Count; ++i0)
      {
          current_alignment += geometry_msgs.msg.TransformStampedPubSubType.getCdrSerializedSize(data.link_infos[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.joint_infos.Count; ++i0)
      {
          current_alignment += halodi_msgs.msg.RobotJointCalibrationInfoPubSubType.getCdrSerializedSize(data.joint_infos[i0], current_alignment);}


      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.ExtrinsicCalibrationInfo data, Halodi.CDR.CDRSerializer cdr)
   {
      	if(data.sensor_transforms == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int sensor_transforms_length = data.sensor_transforms.Count;
            cdr.write_type_2(sensor_transforms_length);
            for (int i0 = 0; i0 < sensor_transforms_length; i0++)
            {
      			geometry_msgs.msg.TransformStampedPubSubType.write(data.sensor_transforms[i0], cdr);	      }
        }
      	if(data.link_infos == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int link_infos_length = data.link_infos.Count;
            cdr.write_type_2(link_infos_length);
            for (int i0 = 0; i0 < link_infos_length; i0++)
            {
      			geometry_msgs.msg.TransformStampedPubSubType.write(data.link_infos[i0], cdr);	      }
        }
      	if(data.joint_infos == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int joint_infos_length = data.joint_infos.Count;
            cdr.write_type_2(joint_infos_length);
            for (int i0 = 0; i0 < joint_infos_length; i0++)
            {
      			halodi_msgs.msg.RobotJointCalibrationInfoPubSubType.write(data.joint_infos[i0], cdr);	      }
        }
   }

   public static void read(halodi_msgs.msg.ExtrinsicCalibrationInfo data, Halodi.CDR.CDRDeserializer cdr)
   {

      int sensor_transforms_length = cdr.read_type_2();
      data.sensor_transforms = new System.Collections.Generic.List<geometry_msgs.msg.TransformStamped>(sensor_transforms_length);
      for(int i = 0; i < sensor_transforms_length; i++)
      {
      	geometry_msgs.msg.TransformStamped new_sensor_transforms = geometry_msgs.msg.TransformStampedPubSubType.Create(); 
      	geometry_msgs.msg.TransformStampedPubSubType.read(new_sensor_transforms, cdr);
      	data.sensor_transforms.Add(new_sensor_transforms);	
      	
      }

      	

      int link_infos_length = cdr.read_type_2();
      data.link_infos = new System.Collections.Generic.List<geometry_msgs.msg.TransformStamped>(link_infos_length);
      for(int i = 0; i < link_infos_length; i++)
      {
      	geometry_msgs.msg.TransformStamped new_link_infos = geometry_msgs.msg.TransformStampedPubSubType.Create(); 
      	geometry_msgs.msg.TransformStampedPubSubType.read(new_link_infos, cdr);
      	data.link_infos.Add(new_link_infos);	
      	
      }

      	

      int joint_infos_length = cdr.read_type_2();
      data.joint_infos = new System.Collections.Generic.List<halodi_msgs.msg.RobotJointCalibrationInfo>(joint_infos_length);
      for(int i = 0; i < joint_infos_length; i++)
      {
      	halodi_msgs.msg.RobotJointCalibrationInfo new_joint_infos = halodi_msgs.msg.RobotJointCalibrationInfoPubSubType.Create(); 
      	halodi_msgs.msg.RobotJointCalibrationInfoPubSubType.read(new_joint_infos, cdr);
      	data.joint_infos.Add(new_joint_infos);	
      	
      }

      	

   }


    public static void Copy(halodi_msgs.msg.ExtrinsicCalibrationInfo src, halodi_msgs.msg.ExtrinsicCalibrationInfo target)
    {
        target.Set(src);
    }


}


}