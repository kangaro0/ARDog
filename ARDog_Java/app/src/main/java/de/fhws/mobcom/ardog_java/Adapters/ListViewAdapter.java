package de.fhws.mobcom.ardog_java.Adapters;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.TextView;

import java.util.ArrayList;

import de.fhws.mobcom.ardog_java.R;

/**
 * Created by kanga on 01.02.2018.
 */

public class ListViewAdapter extends ArrayAdapter {
    private final Context context;

    ArrayList<Object> objects;

    public ListViewAdapter( Context context, int resourceId, ArrayList<Object> objects ){
        super( context, resourceId, objects );

        this.objects = objects;
    }

    @Override
    public int getCount() {
        return this.objects.size();
    }

    @Override
    public Object getItem(int i) {
        if( this.objects.size() - 1 < i )
            return null;
        return this.objects.get( i );
    }

    @Override
    public long getItemId( int i ) {
        return 0;
    }

    @Override
    public View getView(int i, View view, ViewGroup viewGroup) {
        Object obj = this.objects.get( i );

        LayoutInflater inflater = ( LayoutInflater ) context.getSystemService( Context.LAYOUT_INFLATER_SERVICE );
        View itemView = inflater.inflate( R.layout.listview_item, viewGroup, false );
        TextView textView = ( TextView ) itemView.findViewById( R.id.item_text );
        textView.setText( "Dummy" );   // obj.getName();

        return itemView;
    }
}
