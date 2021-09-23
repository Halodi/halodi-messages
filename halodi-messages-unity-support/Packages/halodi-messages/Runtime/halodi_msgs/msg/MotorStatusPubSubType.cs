using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "MotorStatus" defined in "MotorStatus.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from MotorStatus.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit MotorStatus.idl instead.
*
*/
public class MotorStatusPubSubType : Halodi.CDR.TopicDataType<MotorStatus>
{
   public override string Name => "halodi_msgs::msg::dds_::MotorStatus_";


   
   public override void serialize(halodi_msgs.msg.MotorStatus data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, halodi_msgs.msg.MotorStatus data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.MotorStatus data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.MotorStatus data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += halodi_msgs.msg.RobotStatusLevelPubSubType.getCdrSerializedSize(data.status_level, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.joints.Count; ++i0)
      {
          current_alignment += halodi_msgs.msg.JointNamePubSubType.getCdrSerializedSize(data.joints[i0], current_alignment);}

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);



      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.MotorStatus data, Halodi.CDR.CDRSerializer cdr)
   {
      halodi_msgs.msg.RobotStatusLevelPubSubType.write(data.status_level, cdr);

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
      			halodi_msgs.msg.JointNamePubSubType.write(data.joints[i0], cdr);	      }
        }
      cdr.write_type_9(data.motor_id);

      cdr.write_type_7(data.sto_enabled);

      cdr.write_type_7(data.over_temperature);

      cdr.write_type_4(data.motor_serial_number);

      cdr.write_type_4(data.driver_serial_number);

      cdr.write_type_7(data.motor_initialized);

      cdr.write_type_6(data.motor_temperature);

      cdr.write_type_6(data.driver_temperature);

      cdr.write_type_9(data.motor_error);

   }

   public static void read(halodi_msgs.msg.MotorStatus data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.status_level = halodi_msgs.msg.RobotStatusLevelPubSubType.Create();
      halodi_msgs.msg.RobotStatusLevelPubSubType.read(data.status_level, cdr);
      	

      int joints_length = cdr.read_type_2();
      data.joints = new System.Collections.Generic.List<halodi_msgs.msg.JointName>(joints_length);
      for(int i = 0; i < joints_length; i++)
      {
      	halodi_msgs.msg.JointName new_joints = halodi_msgs.msg.JointNamePubSubType.Create(); 
      	halodi_msgs.msg.JointNamePubSubType.read(new_joints, cdr);
      	data.joints.Add(new_joints);	
      	
      }

      	
      data.motor_id=cdr.read_type_9();
      	
      data.sto_enabled=cdr.read_type_7();
      	
      data.over_temperature=cdr.read_type_7();
      	
      data.motor_serial_number=cdr.read_type_4();
      	
      data.driver_serial_number=cdr.read_type_4();
      	
      data.motor_initialized=cdr.read_type_7();
      	
      data.motor_temperature=cdr.read_type_6();
      	
      data.driver_temperature=cdr.read_type_6();
      	
      data.motor_error=cdr.read_type_9();
      	

   }


    public static void Copy(halodi_msgs.msg.MotorStatus src, halodi_msgs.msg.MotorStatus target)
    {
        target.Set(src);
    }


}


}