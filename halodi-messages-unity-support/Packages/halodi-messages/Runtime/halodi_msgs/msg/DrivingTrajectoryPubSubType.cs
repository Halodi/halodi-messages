using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "DrivingTrajectory" defined in "DrivingTrajectory.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from DrivingTrajectory.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit DrivingTrajectory.idl instead.
*
*/
public class DrivingTrajectoryPubSubType : Halodi.CDR.TopicDataType<DrivingTrajectory>
{
   public override string Name => "halodi_msgs::msg::dds_::DrivingTrajectory_";


   
   public override void serialize(halodi_msgs.msg.DrivingTrajectory data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, halodi_msgs.msg.DrivingTrajectory data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.DrivingTrajectory data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.DrivingTrajectory data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.trajectory_points.Count; ++i0)
      {
          current_alignment += halodi_msgs.msg.DrivingTrajectoryPointPubSubType.getCdrSerializedSize(data.trajectory_points[i0], current_alignment);}


      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.DrivingTrajectory data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_6(data.look_ahead_distance);

      cdr.write_type_6(data.K);

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
      			halodi_msgs.msg.DrivingTrajectoryPointPubSubType.write(data.trajectory_points[i0], cdr);	      }
        }
   }

   public static void read(halodi_msgs.msg.DrivingTrajectory data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.look_ahead_distance=cdr.read_type_6();
      	
      data.K=cdr.read_type_6();
      	

      int trajectory_points_length = cdr.read_type_2();
      data.trajectory_points = new System.Collections.Generic.List<halodi_msgs.msg.DrivingTrajectoryPoint>(trajectory_points_length);
      for(int i = 0; i < trajectory_points_length; i++)
      {
      	halodi_msgs.msg.DrivingTrajectoryPoint new_trajectory_points = halodi_msgs.msg.DrivingTrajectoryPointPubSubType.Create(); 
      	halodi_msgs.msg.DrivingTrajectoryPointPubSubType.read(new_trajectory_points, cdr);
      	data.trajectory_points.Add(new_trajectory_points);	
      	
      }

      	

   }


    public static void Copy(halodi_msgs.msg.DrivingTrajectory src, halodi_msgs.msg.DrivingTrajectory target)
    {
        target.Set(src);
    }


}


}