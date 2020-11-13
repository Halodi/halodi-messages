using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "RobotStatus" defined in "RobotStatus.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from RobotStatus.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit RobotStatus.idl instead.
*
*/
public class RobotStatusPubSubType : Halodi.CDR.TopicDataType<RobotStatus>
{
   public override string Name => "halodi_msgs::msg::dds_::RobotStatus_";


   
   public override void serialize(halodi_msgs.msg.RobotStatus data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, halodi_msgs.msg.RobotStatus data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.RobotStatus data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.RobotStatus data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += halodi_msgs.msg.BatteryStatusPubSubType.getCdrSerializedSize(data.battery_status, current_alignment);

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.joint_status.Count; ++i0)
      {
          current_alignment += halodi_msgs.msg.JointStatusPubSubType.getCdrSerializedSize(data.joint_status[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.motor_status.Count; ++i0)
      {
          current_alignment += halodi_msgs.msg.MotorStatusPubSubType.getCdrSerializedSize(data.motor_status[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);



      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.RobotStatus data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      cdr.write_type_9(data.robot_status_level);

      halodi_msgs.msg.BatteryStatusPubSubType.write(data.battery_status, cdr);

      cdr.write_type_7(data.backpack_estop_enabled);

      cdr.write_type_7(data.wireless_estop_enabled);

      cdr.write_type_7(data.over_temperature);

      cdr.write_type_7(data.driving_disabled);

      	if(data.joint_status == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int joint_status_length = data.joint_status.Count;
            cdr.write_type_2(joint_status_length);
            for (int i0 = 0; i0 < joint_status_length; i0++)
            {
      			halodi_msgs.msg.JointStatusPubSubType.write(data.joint_status[i0], cdr);	      }
        }
      	if(data.motor_status == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int motor_status_length = data.motor_status.Count;
            cdr.write_type_2(motor_status_length);
            for (int i0 = 0; i0 < motor_status_length; i0++)
            {
      			halodi_msgs.msg.MotorStatusPubSubType.write(data.motor_status[i0], cdr);	      }
        }
      cdr.write_type_4(data.runtime_since_start);

      cdr.write_type_4(data.total_runtime);

      cdr.write_type_4(data.numberOfRuns);

   }

   public static void read(halodi_msgs.msg.RobotStatus data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	
      data.robot_status_level=cdr.read_type_9();
      	
      data.battery_status = halodi_msgs.msg.BatteryStatusPubSubType.Create();
      halodi_msgs.msg.BatteryStatusPubSubType.read(data.battery_status, cdr);
      	
      data.backpack_estop_enabled=cdr.read_type_7();
      	
      data.wireless_estop_enabled=cdr.read_type_7();
      	
      data.over_temperature=cdr.read_type_7();
      	
      data.driving_disabled=cdr.read_type_7();
      	

      int joint_status_length = cdr.read_type_2();
      data.joint_status = new System.Collections.Generic.List<halodi_msgs.msg.JointStatus>(joint_status_length);
      for(int i = 0; i < joint_status_length; i++)
      {
      	halodi_msgs.msg.JointStatus new_joint_status = halodi_msgs.msg.JointStatusPubSubType.Create(); 
      	halodi_msgs.msg.JointStatusPubSubType.read(new_joint_status, cdr);
      	data.joint_status.Add(new_joint_status);	
      	
      }

      	

      int motor_status_length = cdr.read_type_2();
      data.motor_status = new System.Collections.Generic.List<halodi_msgs.msg.MotorStatus>(motor_status_length);
      for(int i = 0; i < motor_status_length; i++)
      {
      	halodi_msgs.msg.MotorStatus new_motor_status = halodi_msgs.msg.MotorStatusPubSubType.Create(); 
      	halodi_msgs.msg.MotorStatusPubSubType.read(new_motor_status, cdr);
      	data.motor_status.Add(new_motor_status);	
      	
      }

      	
      data.runtime_since_start=cdr.read_type_4();
      	
      data.total_runtime=cdr.read_type_4();
      	
      data.numberOfRuns=cdr.read_type_4();
      	

   }


    public static void Copy(halodi_msgs.msg.RobotStatus src, halodi_msgs.msg.RobotStatus target)
    {
        target.Set(src);
    }


}


}