package de.fhws.mobcom.ardog_java.Adapters;

import android.content.Context;
import android.support.annotation.NonNull;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.TextView;

import java.util.ArrayList;

import de.fhws.mobcom.ardog_java.Objects.Room;
import de.fhws.mobcom.ardog_java.R;
import de.fhws.mobcom.ardog_java.Sql.DBRoom;

/**
 * Created by kanga on 03.02.2018.
 */

public class RoomAdapter extends ArrayAdapter {
    private final Context context;
    private final int resourceId;

    ArrayList<Room> rooms;

    public RoomAdapter(@NonNull Context context, int resource, ArrayList<Room> rooms ) {
        super(context, resource);
        this.context = context;
        this.resourceId = resource;
        this.rooms = rooms;
    }

    @Override
    public int getCount() {
        return this.rooms.size();
    }

    @Override
    public Object getItem(int i) {
        if( this.rooms.size() - 1 < i )
            return null;
        return this.rooms.get( i );
    }

    @Override
    public long getItemId( int i ) {
        return 0;
    }

    @Override
    public View getView(int i, View view, ViewGroup viewGroup) {
        Room obj = rooms.get( i );

        LayoutInflater inflater = ( LayoutInflater ) context.getSystemService( Context.LAYOUT_INFLATER_SERVICE );
        View itemView = inflater.inflate( this.resourceId, viewGroup, false );

        TextView textView = ( TextView ) itemView.findViewById( R.id.item_text );
        textView.setText( obj.getName() );   // obj.getName();

        TextView uuidView = ( TextView ) itemView.findViewById( R.id.item_uuid );

        return itemView;
    }
}
