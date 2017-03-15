// This file was generated by typhen-api

package battle

import (
	"errors"
	"fmt"
	"github.com/shiwano/submarine/server/battle/lib/typhenapi"
	"net/url"
)

var _ = errors.New

type FindRoomRequestBody struct {
	RoomId int64 `json:"room_id" msgpack:"room_id"`
}

// Coerce the fields.
func (t *FindRoomRequestBody) Coerce() error {
	return nil
}

// Bytes creates the byte array.
func (t *FindRoomRequestBody) Bytes(serializer typhenapi.Serializer) ([]byte, error) {
	if err := t.Coerce(); err != nil {
		return nil, err
	}

	data, err := serializer.Serialize(t)
	if err != nil {
		return nil, err
	}

	return data, nil
}

// QueryString returns the query string.
func (t *FindRoomRequestBody) QueryString() string {
	queryString := fmt.Sprintf("room_id=%v", t.RoomId)
	return url.QueryEscape(queryString)
}
