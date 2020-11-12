using System.IO;
namespace visualization_msgs.msg
{

/**
* 
* Topic data type of the struct "MarkerArray" defined in "MarkerArray.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from MarkerArray.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit MarkerArray.idl instead.
*
*/
public class MarkerArrayPubSubType : Halodi.CDR.TopicDataType<visualization_msgs.msg.MarkerArray>
{
   public override string Name => "visualization_msgs::msg::dds_::MarkerArray_";


   
   public override void serialize(visualization_msgs.msg.MarkerArray data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, visualization_msgs.msg.MarkerArray data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(visualization_msgs.msg.MarkerArray data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(visualization_msgs.msg.MarkerArray data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.markers.Count; ++i0)
      {
          current_alignment += visualization_msgs.msg.MarkerPubSubType.getCdrSerializedSize(data.markers[i0], current_alignment);}

      return current_alignment - initial_alignment;
   }

   public static void write(visualization_msgs.msg.MarkerArray data, Halodi.CDR.CDRSerializer cdr)
   {
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
        }   }

   public static void read(visualization_msgs.msg.MarkerArray data, Halodi.CDR.CDRDeserializer cdr)
   {

      int markers_length = cdr.read_type_2();
      data.markers = new System.Collections.Generic.List<visualization_msgs.msg.Marker>(markers_length);
      for(int i = 0; i < markers_length; i++)
      {
      	visualization_msgs.msg.Marker new_markers = visualization_msgs.msg.MarkerPubSubType.Create(); 
      	visualization_msgs.msg.MarkerPubSubType.read(new_markers, cdr);
      	data.markers.Add(new_markers);	
      	
      }

      	

   }


    public static void Copy(visualization_msgs.msg.MarkerArray src, visualization_msgs.msg.MarkerArray target)
    {
        target.Set(src);
    }


}


}