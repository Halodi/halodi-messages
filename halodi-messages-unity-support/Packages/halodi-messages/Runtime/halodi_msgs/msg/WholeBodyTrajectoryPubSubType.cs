using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "WholeBodyTrajectory" defined in "WholeBodyTrajectory.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from WholeBodyTrajectory.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit WholeBodyTrajectory.idl instead.
*
*/
public class WholeBodyTrajectoryPubSubType : Halodi.CDR.TopicDataType<WholeBodyTrajectory>
{
   public override string Name => "halodi_msgs::msg::dds_::WholeBodyTrajectory_";


   public static int getCdrSerializedSize(halodi_msgs.msg.WholeBodyTrajectory data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.WholeBodyTrajectory data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += unique_identifier_msgs.msg.UUIDPubSubType.getCdrSerializedSize(data.trajectory_id, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.start_time.Count; ++i0)
      {
          current_alignment += builtin_interfaces.msg.TimePubSubType.getCdrSerializedSize(data.start_time[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.balance_mode.Count; ++i0)
      {
          current_alignment += halodi_msgs.msg.BalanceModePubSubType.getCdrSerializedSize(data.balance_mode[i0], current_alignment);}

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += halodi_msgs.msg.TrajectoryInterpolationPubSubType.getCdrSerializedSize(data.interpolation_mode, current_alignment);

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.trajectory_points.Count; ++i0)
      {
          current_alignment += halodi_msgs.msg.WholeBodyTrajectoryPointPubSubType.getCdrSerializedSize(data.trajectory_points[i0], current_alignment);}


      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.WholeBodyTrajectory data, Halodi.CDR.CDRSerializer cdr)
   {
      unique_identifier_msgs.msg.UUIDPubSubType.write(data.trajectory_id, cdr);

      	if(data.start_time == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int start_time_length = data.start_time.Count;
            cdr.write_type_2(start_time_length);
            for (int i0 = 0; i0 < start_time_length; i0++)
            {
      			builtin_interfaces.msg.TimePubSubType.write(data.start_time[i0], cdr);	      }
        }
      	if(data.balance_mode == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int balance_mode_length = data.balance_mode.Count;
            cdr.write_type_2(balance_mode_length);
            for (int i0 = 0; i0 < balance_mode_length; i0++)
            {
      			halodi_msgs.msg.BalanceModePubSubType.write(data.balance_mode[i0], cdr);	      }
        }
      cdr.write_type_7(data.append_trajectory);

      halodi_msgs.msg.TrajectoryInterpolationPubSubType.write(data.interpolation_mode, cdr);

      cdr.write_type_6(data.low_pass_filter_break_frequency);

      	if(data.trajectory_points == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int trajectory_points_length = data.trajectory_points.Count;
            cdr.write_type_2(trajectory_points_length);
            for (int i0 = 0; i0 < trajectory_points_length; i0++)
            {
      			halodi_msgs.msg.WholeBodyTrajectoryPointPubSubType.write(data.trajectory_points[i0], cdr);	      }
        }
   }

   public static void read(halodi_msgs.msg.WholeBodyTrajectory data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.trajectory_id = unique_identifier_msgs.msg.UUIDPubSubType.Create();
      unique_identifier_msgs.msg.UUIDPubSubType.read(data.trajectory_id, cdr);
      	

      int start_time_length = cdr.read_type_2();
      data.start_time = new System.Collections.Generic.List<builtin_interfaces.msg.Time>(start_time_length);
      for(int i = 0; i < start_time_length; i++)
      {
      	builtin_interfaces.msg.Time new_start_time = builtin_interfaces.msg.TimePubSubType.Create(); 
      	builtin_interfaces.msg.TimePubSubType.read(new_start_time, cdr);
      	data.start_time.Add(new_start_time);	
      	
      }

      	

      int balance_mode_length = cdr.read_type_2();
      data.balance_mode = new System.Collections.Generic.List<halodi_msgs.msg.BalanceMode>(balance_mode_length);
      for(int i = 0; i < balance_mode_length; i++)
      {
      	halodi_msgs.msg.BalanceMode new_balance_mode = halodi_msgs.msg.BalanceModePubSubType.Create(); 
      	halodi_msgs.msg.BalanceModePubSubType.read(new_balance_mode, cdr);
      	data.balance_mode.Add(new_balance_mode);	
      	
      }

      	
      data.append_trajectory=cdr.read_type_7();
      	
      data.interpolation_mode = halodi_msgs.msg.TrajectoryInterpolationPubSubType.Create();
      halodi_msgs.msg.TrajectoryInterpolationPubSubType.read(data.interpolation_mode, cdr);
      	
      data.low_pass_filter_break_frequency=cdr.read_type_6();
      	

      int trajectory_points_length = cdr.read_type_2();
      data.trajectory_points = new System.Collections.Generic.List<halodi_msgs.msg.WholeBodyTrajectoryPoint>(trajectory_points_length);
      for(int i = 0; i < trajectory_points_length; i++)
      {
      	halodi_msgs.msg.WholeBodyTrajectoryPoint new_trajectory_points = halodi_msgs.msg.WholeBodyTrajectoryPointPubSubType.Create(); 
      	halodi_msgs.msg.WholeBodyTrajectoryPointPubSubType.read(new_trajectory_points, cdr);
      	data.trajectory_points.Add(new_trajectory_points);	
      	
      }

      	

   }


	public override void Serialize(halodi_msgs.msg.WholeBodyTrajectory data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(halodi_msgs.msg.WholeBodyTrajectory data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(halodi_msgs.msg.WholeBodyTrajectory data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(halodi_msgs.msg.WholeBodyTrajectory src, halodi_msgs.msg.WholeBodyTrajectory target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(halodi_msgs.msg.WholeBodyTrajectory src, halodi_msgs.msg.WholeBodyTrajectory target)
    {
    	Copy(src, target);
    }


}


}