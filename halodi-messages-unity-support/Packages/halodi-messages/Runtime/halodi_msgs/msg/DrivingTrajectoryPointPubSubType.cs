using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "DrivingTrajectoryPoint" defined in "DrivingTrajectoryPoint.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from DrivingTrajectoryPoint.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit DrivingTrajectoryPoint.idl instead.
*
*/
public class DrivingTrajectoryPointPubSubType : Halodi.CDR.TopicDataType<DrivingTrajectoryPoint>
{
   public override string Name => "halodi_msgs::msg::dds_::DrivingTrajectoryPoint_";


   public static int getCdrSerializedSize(halodi_msgs.msg.DrivingTrajectoryPoint data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.DrivingTrajectoryPoint data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.DrivingTrajectoryPoint data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_6(data.x);

      cdr.write_type_6(data.y);

      cdr.write_type_6(data.yaw);

      cdr.write_type_6(data.desired_linear_velocity);

      cdr.write_type_6(data.desired_angular_velocity);

   }

   public static void read(halodi_msgs.msg.DrivingTrajectoryPoint data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.x=cdr.read_type_6();
      	
      data.y=cdr.read_type_6();
      	
      data.yaw=cdr.read_type_6();
      	
      data.desired_linear_velocity=cdr.read_type_6();
      	
      data.desired_angular_velocity=cdr.read_type_6();
      	

   }


	public override void Serialize(halodi_msgs.msg.DrivingTrajectoryPoint data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(halodi_msgs.msg.DrivingTrajectoryPoint data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(halodi_msgs.msg.DrivingTrajectoryPoint data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(halodi_msgs.msg.DrivingTrajectoryPoint src, halodi_msgs.msg.DrivingTrajectoryPoint target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(halodi_msgs.msg.DrivingTrajectoryPoint src, halodi_msgs.msg.DrivingTrajectoryPoint target)
    {
    	Copy(src, target);
    }


}


}