using System.IO;
namespace visualization_msgs.msg
{

/**
* 
* Topic data type of the struct "InteractiveMarkerUpdate" defined in "InteractiveMarkerUpdate.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from InteractiveMarkerUpdate.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit InteractiveMarkerUpdate.idl instead.
*
*/
public class InteractiveMarkerUpdatePubSubType : Halodi.CDR.TopicDataType<InteractiveMarkerUpdate>
{
   public override string Name => "visualization_msgs::msg::dds_::InteractiveMarkerUpdate_";


   public static int getCdrSerializedSize(visualization_msgs.msg.InteractiveMarkerUpdate data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(visualization_msgs.msg.InteractiveMarkerUpdate data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.server_id.Length + 1;

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.markers.Count; ++i0)
      {
          current_alignment += visualization_msgs.msg.InteractiveMarkerPubSubType.getCdrSerializedSize(data.markers[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.poses.Count; ++i0)
      {
          current_alignment += visualization_msgs.msg.InteractiveMarkerPosePubSubType.getCdrSerializedSize(data.poses[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.erases.Count; ++i0)
      {
          current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.erases[i0].Length + 1;
      }

      return current_alignment - initial_alignment;
   }

   public static void write(visualization_msgs.msg.InteractiveMarkerUpdate data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_d(data.server_id);

      cdr.write_type_12(data.seq_num);

      cdr.write_type_9(data.type);

      	if(data.markers == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int markers_length = data.markers.Count;
            cdr.write_type_2(markers_length);
            for (int i0 = 0; i0 < markers_length; i0++)
            {
      			visualization_msgs.msg.InteractiveMarkerPubSubType.write(data.markers[i0], cdr);	      }
        }
      	if(data.poses == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int poses_length = data.poses.Count;
            cdr.write_type_2(poses_length);
            for (int i0 = 0; i0 < poses_length; i0++)
            {
      			visualization_msgs.msg.InteractiveMarkerPosePubSubType.write(data.poses[i0], cdr);	      }
        }
      	if(data.erases == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int erases_length = data.erases.Count;
            cdr.write_type_2(erases_length);
            for (int i0 = 0; i0 < erases_length; i0++)
            {
      			cdr.write_type_d(data.erases[i0]);
            }
        }
   }

   public static void read(visualization_msgs.msg.InteractiveMarkerUpdate data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.server_id = cdr.read_type_d();	
      data.seq_num=cdr.read_type_12();
      	
      data.type=cdr.read_type_9();
      	

      int markers_length = cdr.read_type_2();
      data.markers = new System.Collections.Generic.List<visualization_msgs.msg.InteractiveMarker>(markers_length);
      for(int i = 0; i < markers_length; i++)
      {
      	visualization_msgs.msg.InteractiveMarker new_markers = visualization_msgs.msg.InteractiveMarkerPubSubType.Create(); 
      	visualization_msgs.msg.InteractiveMarkerPubSubType.read(new_markers, cdr);
      	data.markers.Add(new_markers);	
      	
      }

      	

      int poses_length = cdr.read_type_2();
      data.poses = new System.Collections.Generic.List<visualization_msgs.msg.InteractiveMarkerPose>(poses_length);
      for(int i = 0; i < poses_length; i++)
      {
      	visualization_msgs.msg.InteractiveMarkerPose new_poses = visualization_msgs.msg.InteractiveMarkerPosePubSubType.Create(); 
      	visualization_msgs.msg.InteractiveMarkerPosePubSubType.read(new_poses, cdr);
      	data.poses.Add(new_poses);	
      	
      }

      	

      int erases_length = cdr.read_type_2();
      data.erases = new System.Collections.Generic.List<string>(erases_length);
      for(int i = 0; i < erases_length; i++)
      {
      	data.erases.Add(cdr.read_type_d());	
      	
      }

      	

   }


	public override void Serialize(visualization_msgs.msg.InteractiveMarkerUpdate data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(visualization_msgs.msg.InteractiveMarkerUpdate data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(visualization_msgs.msg.InteractiveMarkerUpdate data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(visualization_msgs.msg.InteractiveMarkerUpdate src, visualization_msgs.msg.InteractiveMarkerUpdate target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(visualization_msgs.msg.InteractiveMarkerUpdate src, visualization_msgs.msg.InteractiveMarkerUpdate target)
    {
    	Copy(src, target);
    }


}


}