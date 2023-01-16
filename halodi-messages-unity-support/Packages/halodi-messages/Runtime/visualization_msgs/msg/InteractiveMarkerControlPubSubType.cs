using System.IO;
namespace visualization_msgs.msg
{

/**
* 
* Topic data type of the struct "InteractiveMarkerControl" defined in "InteractiveMarkerControl.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from InteractiveMarkerControl.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit InteractiveMarkerControl.idl instead.
*
*/
public class InteractiveMarkerControlPubSubType : Halodi.CDR.TopicDataType<InteractiveMarkerControl>
{
   public override string Name => "visualization_msgs::msg::dds_::InteractiveMarkerControl_";


   public static int getCdrSerializedSize(visualization_msgs.msg.InteractiveMarkerControl data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(visualization_msgs.msg.InteractiveMarkerControl data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.name.Length + 1;

      current_alignment += geometry_msgs.msg.QuaternionPubSubType.getCdrSerializedSize(data.orientation, current_alignment);

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.markers.Count; ++i0)
      {
          current_alignment += visualization_msgs.msg.MarkerPubSubType.getCdrSerializedSize(data.markers[i0], current_alignment);}

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.description.Length + 1;


      return current_alignment - initial_alignment;
   }

   public static void write(visualization_msgs.msg.InteractiveMarkerControl data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_d(data.name);

      geometry_msgs.msg.QuaternionPubSubType.write(data.orientation, cdr);

      cdr.write_type_9(data.orientation_mode);

      cdr.write_type_9(data.interaction_mode);

      cdr.write_type_7(data.always_visible);

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
      			visualization_msgs.msg.MarkerPubSubType.write(data.markers[i0], cdr);	      }
        }
      cdr.write_type_7(data.independent_marker_orientation);

      cdr.write_type_d(data.description);

   }

   public static void read(visualization_msgs.msg.InteractiveMarkerControl data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.name = cdr.read_type_d();	
      data.orientation = geometry_msgs.msg.QuaternionPubSubType.Create();
      geometry_msgs.msg.QuaternionPubSubType.read(data.orientation, cdr);
      	
      data.orientation_mode=cdr.read_type_9();
      	
      data.interaction_mode=cdr.read_type_9();
      	
      data.always_visible=cdr.read_type_7();
      	

      int markers_length = cdr.read_type_2();
      data.markers = new System.Collections.Generic.List<visualization_msgs.msg.Marker>(markers_length);
      for(int i = 0; i < markers_length; i++)
      {
      	visualization_msgs.msg.Marker new_markers = visualization_msgs.msg.MarkerPubSubType.Create(); 
      	visualization_msgs.msg.MarkerPubSubType.read(new_markers, cdr);
      	data.markers.Add(new_markers);	
      	
      }

      	
      data.independent_marker_orientation=cdr.read_type_7();
      	
      data.description = cdr.read_type_d();	

   }


	public override void Serialize(visualization_msgs.msg.InteractiveMarkerControl data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(visualization_msgs.msg.InteractiveMarkerControl data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(visualization_msgs.msg.InteractiveMarkerControl data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(visualization_msgs.msg.InteractiveMarkerControl src, visualization_msgs.msg.InteractiveMarkerControl target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(visualization_msgs.msg.InteractiveMarkerControl src, visualization_msgs.msg.InteractiveMarkerControl target)
    {
    	Copy(src, target);
    }


}


}