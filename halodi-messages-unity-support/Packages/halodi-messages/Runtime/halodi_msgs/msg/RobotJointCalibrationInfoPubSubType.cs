using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "RobotJointCalibrationInfo" defined in "RobotJointCalibrationInfo.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from RobotJointCalibrationInfo.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit RobotJointCalibrationInfo.idl instead.
*
*/
public class RobotJointCalibrationInfoPubSubType : Halodi.CDR.TopicDataType<RobotJointCalibrationInfo>
{
   public override string Name => "halodi_msgs::msg::dds_::RobotJointCalibrationInfo_";


   
   public override void serialize(halodi_msgs.msg.RobotJointCalibrationInfo data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, halodi_msgs.msg.RobotJointCalibrationInfo data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.RobotJointCalibrationInfo data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.RobotJointCalibrationInfo data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.frame_id.Length + 1;

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.RobotJointCalibrationInfo data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_d(data.frame_id);

      cdr.write_type_6(data.transmission_ratio);

      cdr.write_type_6(data.measurement_offset);

   }

   public static void read(halodi_msgs.msg.RobotJointCalibrationInfo data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.frame_id = cdr.read_type_d();	
      data.transmission_ratio=cdr.read_type_6();
      	
      data.measurement_offset=cdr.read_type_6();
      	

   }


    public static void Copy(halodi_msgs.msg.RobotJointCalibrationInfo src, halodi_msgs.msg.RobotJointCalibrationInfo target)
    {
        target.Set(src);
    }


}


}