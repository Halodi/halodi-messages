using System.IO;
namespace visualization_msgs.msg
{

/**
* 
* Topic data type of the struct "InteractiveMarkerInit" defined in "InteractiveMarkerInit.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from InteractiveMarkerInit.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit InteractiveMarkerInit.idl instead.
*
*/
public class InteractiveMarkerInitPubSubType : Halodi.CDR.TopicDataType<InteractiveMarkerInit>
{
   public override string Name => "visualization_msgs::msg::dds_::InteractiveMarkerInit_";


   public static int getCdrSerializedSize(visualization_msgs.msg.InteractiveMarkerInit data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(visualization_msgs.msg.InteractiveMarkerInit data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.server_id.Length + 1;

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.markers.Count; ++i0)
      {
          current_alignment += visualization_msgs.msg.InteractiveMarkerPubSubType.getCdrSerializedSize(data.markers[i0], current_alignment);}


      return current_alignment - initial_alignment;
   }

   public static void write(visualization_msgs.msg.InteractiveMarkerInit data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_d(data.server_id);

      cdr.write_type_12(data.seq_num);

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
   }

   public static void read(visualization_msgs.msg.InteractiveMarkerInit data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.server_id = cdr.read_type_d();	
      data.seq_num=cdr.read_type_12();
      	

      int markers_length = cdr.read_type_2();
      data.markers = new System.Collections.Generic.List<visualization_msgs.msg.InteractiveMarker>(markers_length);
      for(int i = 0; i < markers_length; i++)
      {
      	visualization_msgs.msg.InteractiveMarker new_markers = visualization_msgs.msg.InteractiveMarkerPubSubType.Create(); 
      	visualization_msgs.msg.InteractiveMarkerPubSubType.read(new_markers, cdr);
      	data.markers.Add(new_markers);	
      	
      }

      	

   }


	public override void Serialize(visualization_msgs.msg.InteractiveMarkerInit data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(visualization_msgs.msg.InteractiveMarkerInit data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(visualization_msgs.msg.InteractiveMarkerInit data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(visualization_msgs.msg.InteractiveMarkerInit src, visualization_msgs.msg.InteractiveMarkerInit target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(visualization_msgs.msg.InteractiveMarkerInit src, visualization_msgs.msg.InteractiveMarkerInit target)
    {
    	Copy(src, target);
    }


}


}