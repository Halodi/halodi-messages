using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "ARMarkers" defined in "ARMarkers.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from ARMarkers.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit ARMarkers.idl instead.
*
*/
public class ARMarkersPubSubType : Halodi.CDR.TopicDataType<ARMarkers>
{
   public override string Name => "halodi_msgs::msg::dds_::ARMarkers_";


   public static int getCdrSerializedSize(halodi_msgs.msg.ARMarkers data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.ARMarkers data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.markers.Count; ++i0)
      {
          current_alignment += halodi_msgs.msg.ARMarkerPubSubType.getCdrSerializedSize(data.markers[i0], current_alignment);}


      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.ARMarkers data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

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
      			halodi_msgs.msg.ARMarkerPubSubType.write(data.markers[i0], cdr);	      }
        }
   }

   public static void read(halodi_msgs.msg.ARMarkers data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	

      int markers_length = cdr.read_type_2();
      data.markers = new System.Collections.Generic.List<halodi_msgs.msg.ARMarker>(markers_length);
      for(int i = 0; i < markers_length; i++)
      {
      	halodi_msgs.msg.ARMarker new_markers = halodi_msgs.msg.ARMarkerPubSubType.Create(); 
      	halodi_msgs.msg.ARMarkerPubSubType.read(new_markers, cdr);
      	data.markers.Add(new_markers);	
      	
      }

      	

   }


	public override void Serialize(halodi_msgs.msg.ARMarkers data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(halodi_msgs.msg.ARMarkers data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(halodi_msgs.msg.ARMarkers data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(halodi_msgs.msg.ARMarkers src, halodi_msgs.msg.ARMarkers target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(halodi_msgs.msg.ARMarkers src, halodi_msgs.msg.ARMarkers target)
    {
    	Copy(src, target);
    }


}


}